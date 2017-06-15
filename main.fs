\ Main function for power supply panel project
-main-module
marker -main-module

\ Timer 0 interrupt
: tmr0-irq
    [i
        %100 intcon mtst if \ Test TMR0IF
            disp_upd
            %100 intcon mclr \ Clear TMR0IF
        then
    i]
;i

\ Setup hardware
: init ( -- )
    \ Init GPIOs
    $ff trisa mset
    $ff latb mset
    $ff latd mset
    %111111 latc mset
    %111111 trisc mclr
    $ff trisb mclr
    $ff trisd mclr
    \ Init ADC, AN0...AN4 are analog, Fadc=Fosc/64, right justified
    %11000010 adcon1 c!
    %10000000 adcon0 c!
    1 adcon0 mset
    \ Init TMR0, prescaler = 128, 8b mode, overflow every 3.2ms !!! 
    %11000110 t0con c!
    \ Install interrupt service word
    ['] tmr0-irq 0 int!
    \ Clear TMR0 interrupt
    %100 intcon mclr
    \ Global interrupt enable, TMR0 interrupt enable
    %10100000 intcon mset
    \ Init global var
    0 disp_pos ! \ Set display position to 0
;

\ Main entry point
: main ( -- )
    init \ Setup hardware
    fl-
    0 disp_pos ! \ Set display position to 0
    \ Display test numbers
    123 dispV1
    456 dispA1
    789 dispV2
    321 dispA2
    begin
        \ Do nothing
        \ cwd
        \ disp_upd
	cr
	0 adc@ dup volts@ dup u. dispV2
	2 adc@ amps2@ dup u. dispA2 
	1 adc@ dup volts@ dup u. dispV1
	3 adc@ amps1@ dup u. dispA1
        200 ms
    key? until
;

' main is turnkey

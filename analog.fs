-read-adc
marker -read-adc

eeprom 
variable a1mul
variable a2mul
ram

\ Get analog channel value
: adc@ ( ch -- u )
    3 lshift  \ shift channel number to its position in adcon0
    adcon0 c@ \ read, modify and put back adcon0
    %11000011 and
    or 
    adcon0 c!
    1 ms      \ wait acquisition time
    %100 adcon0 mset \ start conversion
    begin %100 adcon0 mtst 0= until \ wait until conversion done
    adresl @  \ read 16-bit result at once
;

\ Get voltage from ADC value
: volts@ ( adc -- u )
    dup 690 2048 um*/ swap drop
;

\ Unsigned difference
: udiff ( u u -- u )
    - dup 32767 > if drop 0 then
;

\ Get current in 1st channel
: amps1@ ( adc1 adc2 -- u )
    udiff 
    dup
    a1mul @
    2048 um*/ swap drop
;

\ Get current in 2nd channel
: amps2@ ( adc1 adc2 -- u )
    udiff 
    dup
    a2mul @
    2048 um*/ swap drop
;


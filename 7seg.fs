\ Words for control 12-digit dynamic 7-segment display.
-7seg-control
marker -7seg-control

\ 0...15 - hex digits, 16 - space
flash
create digit_codes
    $11 c, $7d c, $23 c, $29 c,
    $4d c, $89 c, $81 c, $3d c,
    $01 c, $09 c, $05 c, $c1 c,
    $93 c, $61 c, $83 c, $87 c,
    $ff c,

\ Get array element by its index
: get_digit_code ( digit -- code)
    digit_codes swap + c@
;

\ Turn off all LEDs by setting all anodes to 1
: turn_off_all ( -- )
    $3f latc mset
;

\ Turn on LEDs on given position, positions from 0 to 5
: turn_on ( position -- )
    $20 swap rshift invert
    latc c!
;

\ Write code of given digit to port B. Also set DP,
\ which is MSB in input byte.
: portb_digit ( digit -- )
    dup $7f and
    get_digit_code
    swap
    #7 rshift invert and
    latb c!
;

\ Write code of given digit to port D. Also set DP,
\ which is MSB in input byte.
: portd_digit ( digit -- )
    dup $7f and
    get_digit_code
    swap
    #7 rshift invert and
    latd c!
;

\ Show 2 digits on the 12-position 7 segment display. 
\ One digit for left part, second one for right part.
\ Each part of display has 6 positions.
: show_pair ( position d1 d2 -- )
    portd_digit
    portb_digit
    turn_on
;

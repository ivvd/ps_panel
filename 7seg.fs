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

\ Show digit on the 12-position 7 segment display. 
: show_digit ( digit position -- )
    $3f latc mset
    dup 6 < if
        swap get_digit_code
        latb c!
        $20 swap rshift invert
        latc c!
    else
        swap get_digit_code
        latd c!
        6 -
        $20 swap rshift invert
        latc c!
    then
;

-display
marker -display

\ Convert ASCII character to number
: char2num ( c -- n )
    $30 -
;

\ Convert number to ASCII array
: get_ascii ( n -- addr len )
    0 <# # # # #>
;

: dispA2 ( n -- )
    get_ascii
    drop
    dup @ char2num $80 or disp_arr c!
    dup 1 + @ char2num disp_arr 1 + c!
    2 + @ char2num disp_arr 2 + c!
;

: dispV2 ( n -- )
    get_ascii
    drop
    dup @ char2num disp_arr 3 + c!
    dup 1 + @ char2num $80 or disp_arr 4 + c!
    2 + @ char2num disp_arr 5 + c!
;

: dispA1 ( n -- )
    get_ascii
    drop
    dup @ char2num $80 or disp_arr 6 + c!
    dup 1 + @ char2num disp_arr 7 + c!
    2 + @ char2num disp_arr 8 + c!
;

: dispV1 ( n -- )
    get_ascii
    drop
    dup @ char2num disp_arr 9 + c!
    dup 1 + @ char2num $80 or disp_arr #10 + c!
    2 + @ char2num disp_arr #11 + c!
;

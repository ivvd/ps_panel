\ Main function for power supply pannel project
-main-module
marker -main-module

ram
\ Variable for counting display positions
variable disp_pos

flash
: init_disp_arr ( -- )
    #12 for
        #16 disp_arr r@ + c!
    next

    $0 disp_arr #0 + c!
    $81 disp_arr #1 + c!
    $2 disp_arr #2 + c!
    $3 disp_arr #3 + c!
    $84 disp_arr #4 + c!
    $5 disp_arr #5 + c!
    $6 disp_arr #6 + c!
    $87 disp_arr #7 + c!
    $8 disp_arr #8 + c!
    $9 disp_arr #9 + c!
    $8a disp_arr #10 + c!
    $b disp_arr #11 + c!
;

: main ( -- )
    init \ Setup hardware
    0 disp_pos ! \ Set display position to 0
    \ Display test numbers
    123 voltage_1
    456 current_1
    789 voltage_2
    321 current_2
    begin
        disp_pos @
        disp_arr disp_pos @ + c@
        disp_arr disp_pos @ 6 + + c@
        show_pair
        
        \ Update position counter
        disp_pos @
        1 +
        \ If more then 5, set to 0
        dup 5 > if drop 0 then
        disp_pos !

        \ Wait a bit
        #2 ms 
    key? until
;

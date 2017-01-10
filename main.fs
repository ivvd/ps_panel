\ Main function for power supply pannel project
-main-module
marker -main-module

ram
\ 12-cells array for keeping digits to put on display.
create disp_arr allot #12

\ Variable for counting display positions
variable disp_pos

flash
: init_disp_arr ( -- )
    #12 for
        #16 disp_arr r@ + c!
    next

    #0 disp_arr #0 + c!
    #1 disp_arr #1 + c!
    #2 disp_arr #2 + c!
    #3 disp_arr #3 + c!
    #4 disp_arr #4 + c!
    #5 disp_arr #5 + c!
    #6 disp_arr #6 + c!
    #7 disp_arr #7 + c!
    #8 disp_arr #8 + c!
    #9 disp_arr #9 + c!
    #10 disp_arr #10 + c!
    #11 disp_arr #11 + c!
;

: main ( -- )
    init \ Setup hardware
    0 disp_pos ! \ Set display position to 0
    init_disp_arr \ Test number for display
    begin
        disp_arr disp_pos @ + c@
        disp_pos @ show_digit
        disp_arr disp_pos @ 6 + + c@
        disp_pos @ 6 + show_digit
        
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

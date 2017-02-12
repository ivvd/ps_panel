\ Main function for power supply pannel project
-main-module
marker -main-module

ram
\ Variable for counting display positions
variable disp_pos

flash
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

-read-adc
marker -read-adc

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


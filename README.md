## LED display for power supply
This project is attempt to repair damaged LED display for bench power supply.

## Hardware
The display is 12-digit 7 segment LED display comprised to 4 parts. Each part 
has 3 digit and used for displaying voltage and current for 2 channels. 
Power and control board in this power supply is completely independent from 
display module. So it was possible to make a full replacement for this module. 
I used PIC18F452 MCU to control LED display and measure analog signals which 
represent voltages and currents of each power supply's channel. 
[Schematic](https://github.com/ivvd/ps_panel/blob/master/hardware/ps_panel_schematic.pdf)

## Firmware
Firmware is written using [FlashForth](http://www.flashforth.com/), that is Forth 
implementation for Microchip's PIC and AVR microcontrollers.
All interruction with FlashForth firmware inside MCU is via serial port. 
Source code files is loaded as plain text line by line. FlashForth distribution includes 
convinient shell program to do so. It is necessary to load source files in proper sequence to 
avoid usage of Forth words that is undefined yet.
Loading sequence:
1. math.txt (from FlashForth distribution)
2. p18f452.fs
3. 7seg.fs
4. display.fs
5. analog.fs
6. main.fs

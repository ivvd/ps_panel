# ps_panel
FlashForth project for display panel of lab power supply.

# Hardware
There are twelve 7-segment LED displays with common anodes in my panel. 
Cathodes of first six (groupe 1) displays connected to port B in parallel 
with 360 Ohm resistors. Another six ones (groupe 2) connected to port D 
the same way. Also we have a six PNP transistors which bases controled 
by port C 0...5 pins. Collectors of each transistor connected to common 
anodes of two displays (from different groupes).
So active signal for RC0...5 is zero, it selects one display from each groupe.
And default (inactive) state of RC0...5 is one (5 volts).
For segments active state is zero too. And default is 5 volts.

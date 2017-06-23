EESchema Schematic File Version 2
LIBS:power
LIBS:device
LIBS:transistors
LIBS:conn
LIBS:linear
LIBS:regul
LIBS:74xx
LIBS:cmos4000
LIBS:adc-dac
LIBS:memory
LIBS:xilinx
LIBS:microcontrollers
LIBS:dsp
LIBS:microchip
LIBS:analog_switches
LIBS:motorola
LIBS:texas
LIBS:intel
LIBS:audio
LIBS:interface
LIBS:digital-audio
LIBS:philips
LIBS:display
LIBS:cypress
LIBS:siliconi
LIBS:opto
LIBS:atmel
LIBS:contrib
LIBS:valves
LIBS:microchip_pic18mcu
LIBS:ps_panel-cache
EELAYER 25 0
EELAYER END
$Descr A4 11693 8268
encoding utf-8
Sheet 3 4
Title ""
Date ""
Rev ""
Comp ""
Comment1 ""
Comment2 ""
Comment3 ""
Comment4 ""
$EndDescr
$Comp
L 7805 U2
U 1 1 594CEA3E
P 6300 3600
F 0 "U2" H 6450 3404 50  0000 C CNN
F 1 "7805" H 6300 3800 50  0000 C CNN
F 2 "" H 6300 3600 50  0000 C CNN
F 3 "" H 6300 3600 50  0000 C CNN
	1    6300 3600
	1    0    0    -1  
$EndComp
$Comp
L CP C6
U 1 1 594CEAE3
P 6900 3800
F 0 "C6" H 6925 3900 50  0000 L CNN
F 1 "CP" H 6925 3700 50  0000 L CNN
F 2 "" H 6938 3650 50  0000 C CNN
F 3 "" H 6900 3800 50  0000 C CNN
	1    6900 3800
	1    0    0    -1  
$EndComp
$Comp
L CP C5
U 1 1 594CEB84
P 5700 3800
F 0 "C5" H 5725 3900 50  0000 L CNN
F 1 "CP" H 5725 3700 50  0000 L CNN
F 2 "" H 5738 3650 50  0000 C CNN
F 3 "" H 5700 3800 50  0000 C CNN
	1    5700 3800
	1    0    0    -1  
$EndComp
$Comp
L D D5
U 1 1 594CECD2
P 4900 3500
F 0 "D5" H 4900 3600 50  0000 C CNN
F 1 "1N4004" H 4900 3400 50  0000 C CNN
F 2 "" H 4900 3500 50  0000 C CNN
F 3 "" H 4900 3500 50  0000 C CNN
	1    4900 3500
	0    1    1    0   
$EndComp
$Comp
L D D7
U 1 1 594CED81
P 5250 3500
F 0 "D7" H 5250 3600 50  0000 C CNN
F 1 "1N4004" H 5250 3400 50  0000 C CNN
F 2 "" H 5250 3500 50  0000 C CNN
F 3 "" H 5250 3500 50  0000 C CNN
	1    5250 3500
	0    1    1    0   
$EndComp
$Comp
L D D6
U 1 1 594CEDAF
P 4900 4000
F 0 "D6" H 4900 4100 50  0000 C CNN
F 1 "1N4004" H 4900 3900 50  0000 C CNN
F 2 "" H 4900 4000 50  0000 C CNN
F 3 "" H 4900 4000 50  0000 C CNN
	1    4900 4000
	0    1    1    0   
$EndComp
$Comp
L D D8
U 1 1 594CEDE9
P 5250 4000
F 0 "D8" H 5250 4100 50  0000 C CNN
F 1 "1N4004" H 5250 3900 50  0000 C CNN
F 2 "" H 5250 4000 50  0000 C CNN
F 3 "" H 5250 4000 50  0000 C CNN
	1    5250 4000
	0    1    1    0   
$EndComp
$Comp
L CONN_01X03 P5
U 1 1 594CEE13
P 4150 3800
F 0 "P5" H 4150 4000 50  0000 C CNN
F 1 "CONN_01X03" V 4250 3800 50  0000 C CNN
F 2 "" H 4150 3800 50  0000 C CNN
F 3 "" H 4150 3800 50  0000 C CNN
	1    4150 3800
	-1   0    0    1   
$EndComp
Wire Wire Line
	4900 3350 4900 3300
Wire Wire Line
	5250 3300 5250 3350
Wire Wire Line
	4900 3650 4900 3850
Wire Wire Line
	5250 3650 5250 3850
Wire Wire Line
	4900 4150 4900 4200
Wire Wire Line
	5250 4200 5250 4150
Wire Wire Line
	5700 3300 5700 3650
Connection ~ 5250 3300
Wire Wire Line
	5700 4200 5700 3950
Connection ~ 5250 4200
Wire Wire Line
	5900 3550 5700 3550
Connection ~ 5700 3550
Wire Wire Line
	6300 4200 6300 3850
Connection ~ 5700 4200
Wire Wire Line
	6900 4200 6900 3950
Connection ~ 6300 4200
Wire Wire Line
	6700 3550 7550 3550
Wire Wire Line
	6900 3550 6900 3650
Connection ~ 4900 4200
Connection ~ 4900 3300
Connection ~ 6900 3550
Wire Wire Line
	7350 3800 7550 3800
Wire Wire Line
	7350 3800 7350 4200
Connection ~ 6900 4200
Wire Wire Line
	4350 3700 4900 3700
Connection ~ 4900 3700
Wire Wire Line
	4350 3800 5250 3800
Connection ~ 5250 3800
Wire Wire Line
	4900 3300 5700 3300
Wire Wire Line
	7350 4200 4900 4200
NoConn ~ 4350 3900
Text HLabel 7550 3550 2    60   Output ~ 0
+5V
Text HLabel 7550 3800 2    60   Output ~ 0
GND
Text Notes 4000 4350 0    60   ~ 0
1: 9V AC\n2: GND\n3: 9V AC
$EndSCHEMATC

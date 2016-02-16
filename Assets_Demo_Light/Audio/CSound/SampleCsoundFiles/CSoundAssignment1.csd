<CsoundSynthesizer>
<CsOptions>
; put output file and other options here
</CsOptions>
<CsInstruments>

sr = 44100	; Sampling rate
kr = 4410	; K-Data rate
ksmps = 10	; K-samples
nchnls = 2	; channels



; an instrument with variable duration, amplitude, frequency, and oscil function
; with a simple amplitude exponential envelope that goes from 1 to 0.001
instr 101
	idur = p3				; the duration of the note in seconds
	iamp = ampdb(p4)		; the amplitude (in decibels)
	ifreq = cpspch(p5)	; the frequency of the note (in CSound C-scale notation)
	ifn = p6					; the function the oscil function will call


	kexpEnv1 = expseg 1, idur, 0.001)		; simple exponential envelope that goes from 1 to 0.001

	a1 oscil iamp*kexpEnv1, ifreq, ifn		; a1 is the 
		outs	a1, a1								; outputs a1 to left and right channel
endin
	
; an instrument with variable duration, amplitude, frequency, and oscil function
; with a simple variable amplitude exponential envelope (Parameter value must range from 0.0001{greater than 0} to 1)
instr 102
	idur = p3				; the duration of the note in seconds
	iamp = ampdb(p4)		; the amplitude (in decibels)
	ifreq = cpspch(p5)	; the frequency of the note (in CSound C-scale notation)
	ifn = p6					; the function the oscil function will call
	ia = p7					; the starting value for the exponential envelope
	ib = p8					; the ending value for the exponential envelope

	kexpEnv1 = expseg ia, idur, ib)	; simple variable exponential envelope

	asignal oscil iamp*kexpEnv1, ifreq, ifn
		outs asignal * (kpan), asignal * 0	
endin

; an instrument with variable duration, amplitude, frequency, and oscil function
; with a simple variable amplitude exponential envelope (Parameter value must range from 0.0001{greater than 0} to 1)	
; with a simple tremolo implementation
instr 103
	idur = p3				; the duration of the note in seconds
	iamp = ampdb(p4)		; the amplitude (in decibels)
	ifreq = cpspch(p5)	; the frequency of the note (in CSound C-scale notation)
	ifn = p6					; the function the oscil function will call
	ia = p7					; the starting value for the exponential envelope
	ib = p8					; the ending value for the exponential envelope
	itremAmount = p9		; the tremolo amount

	kexpEnv1 = expseg ia, idur, ib) ; simple variable exponential envelope
	kpitch oscil 1, itremAmount, ifn	; oscil that will control amplitude pitch of note; change oscil fn? was originally 1

	kpan line 1, idur, 0	;a simple line to control panning from left to right

	asignal oscil iamp*kexpEnv1*(1-kpitch), ifreq, ifn
		;outs asignal * sqrt(kpan), asignal * (1 - sqrt(kpan))
		outs asignal, asignal	
endin


; an instrument with variable duration, amplitude, frequency, and oscil function
; with a simple variable amplitude exponential envelope (Parameter value must range from 0.0001{greater than 0} to 1)	
; with a simple tremolo implementation
; with a simple panning function
instr 104
	idur = p3				; the duration of the note in seconds
	iamp = ampdb(p4)		; the amplitude (in decibels)
	ifreq = cpspch(p5)	; the frequency of the note (in CSound C-scale notation)
	ifn = p6					; the function the oscil function will call
	ia = p7					; the starting value for the exponential envelope
	ib = p8					; the ending value for the exponential envelope
	itremAmount = p9		; the tremolo amount

	kexpEnv1 = expseg ia, idur, ib) ; simple variable exponential envelope
	kpitch oscil 1, itremAmount, ifn	; oscil that will control amplitude pitch of note; change oscil fn? was originally 1

	kpan line 1, idur, 0	;a simple line to control panning from left to right

	asignal oscil iamp*kexpEnv1*(1-kpitch), ifreq, ifn
		;outs asignal * sqrt(kpan), asignal * (1 - sqrt(kpan))
		outs asignal * (kpan), asignal * (1-kpan)
endin


</CsInstruments>
<CsScore>
; The scoring section which determines the functions it will use and the instruments and note calls
; Functions table 
; fn ? size ? ?
;increasing size sine waves
f 1  0 2 10 1			; size of 2
f 2  0 4 10 1			; size of 4
f 3  0 8 10 1			; ....
f 4  0 16 10 1
f 5  0 32 10 1
f 6  0 64 10 1
f 7  0 128 10 1
f 8  0 256 10 1
f 9  0 512 10 1
f 10 0 1024 10 1
f 11 0 2048 10 1
f 12 0 4096 10 1
f 13 0 8192 10 1

;increasing size square waves through 13 partials
; fn ? size ? ? specifying odd partials
f 21 0 2	10	1		0	1/3	0	1/5	0	1/7	0	1/9	0	1/11	0	1/13
f 22 0 4	10	1		0	1/3	0	1/5	0	1/7	0	1/9	0	1/11	0	1/13
f 23 0 8	10	1		0	1/3	0	1/5	0	1/7	0	1/9	0	1/11	0	1/13
f 24 0 16	10	1	0	1/3	0	1/5	0	1/7	0	1/9	0	1/11	0	1/13
f 25 0 32	10	1	0	1/3	0	1/5	0	1/7	0	1/9	0	1/11	0	1/13
f 26 0 64	10	1	0	1/3	0	1/5	0	1/7	0	1/9	0	1/11	0	1/13
f 27 0 128	10	1	0	1/3	0	1/5	0	1/7	0	1/9	0	1/11	0	1/13
f 28 0 256	10	1	0	1/3	0	1/5	0	1/7	0	1/9	0	1/11	0	1/13
f 29 0 512	10	1	0	1/3	0	1/5	0	1/7	0	1/9	0	1/11	0	1/13
f 30 0 1024	10	1	0	1/3	0	1/5	0	1/7	0	1/9	0	1/11	0	1/13
f 31 0 2048	10	1	0	1/3	0	1/5	0	1/7	0	1/9	0	1/11	0	1/13
f 32 0 4096	10	1	0	1/3	0	1/5	0	1/7	0	1/9	0	1/11	0	1/13
f 33 0 8192	10	1	0	1/3	0	1/5	0	1/7	0	1/9	0	1/11	0	1/13 ; size of 8192


; instrument 103 note calls
; #   t  dur amp freq(cpsch) fn ia ib  trem
i 103 0 		2 80 8.06			13 1	.001	2
i 103 1 		2 80 8.10			13	1	.001	2
i 103 2 		2 80 9.01 			13	1	.001	2
i 103 2.5 	2 80 8.06 			13	1	.001	2
i 103 3 		2 80 9.03 			13	1	.001	2
i 103 4 		2 80 9.06 			13	1	.001	2


s ; represents a break in section, restarts numbering of time to 0

i 103 0 		2 80 8.06	33 1	.001	5
i 103 1 		2 80 8.10	33	1	.001	5
i 103 2 		2 80 9.01 	33	1	.001	5
i 103 2.5 	2 80 8.06 	33	1	.001	5
i 103 3 		2 80 9.03 	33	1	.001	5
i 103 4 		2 80 9.06 	33	1	.001	5


s

i 103 0		2 80 8.06	1 	1	.001	10
i 103 1		2 80 8.10	1	1	.001	10
i 103 2		2 80 9.01 	1	1	.001	10
i 103 2.5	2 80 8.06 	1	1	.001	10
i 103 3		2 80 9.03 	1	1	.001	10
i 103 4		2 80 9.06 	1	1	.001	10

</CsScore>
</CsoundSynthesizer>
<bsbPanel>
 <label>Widgets</label>
 <objectName/>
 <x>100</x>
 <y>100</y>
 <width>320</width>
 <height>240</height>
 <visible>true</visible>
 <uuid/>
 <bgcolor mode="nobackground">
  <r>255</r>
  <g>255</g>
  <b>255</b>
 </bgcolor>
</bsbPanel>
<bsbPresets>
</bsbPresets>

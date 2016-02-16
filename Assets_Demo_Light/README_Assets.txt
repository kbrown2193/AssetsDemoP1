=====
=====
AUDIO
=====
=====

SAFE LISTENING
Always practice safe listening practices especially when listening to audio for long durations of time.
Tip: 1021; After listening to audio for a few minutes turn down the volume a little, you should be able to hear better at a lower level.  Progressively turning down volume till you can still hear audio, and minimize sound levels.  

==========================
AltairsSong_EffectsDemo
==========================
Comment: Only need to listen to a little to get the jist of the effect
Extra (hard shifts) has signals that has swift changes to pitch and delay in real time on the signal, so not necessairly musically pleasing qualities, but nonetheless represents live signal changes.
Main Point:  Live signal audio effects
%%%%%%%%%%%%%%%%%%%%%%%%%%

For these audio files the left channel is the channel without any delay
Right channel has Delay Effects.


Effects Chain
-------------
							            ---------   --> Looper Left	--> Mixer Input 1
Instrument --> Compression Pedal --> Preamp --> Fork --> Chorus----|
								    Delay Pedal --> Looper Right --> Mixer Input 2

Mixer Input 1 pamnned to Left
Mixer Input 2 panned to Right
both have high frequencies attenuated

Mixer Output L --> Recorder L
Mixer Output R --> Recorder R



Compression pedal: This pedal does not peform compression in the sense of less data.
It is compression in the sense that it keeps the signal input in a relativly smalleer scale, but keeps values from getting out of range from the input.
Also has volume control, blend, tone, sustain, and attack controls.  

Preamp: This has some tone control and volume and gain control

Fork: This can supplement frequencies of related rates above, below , or both from the original signal.  Usually set to an octave.

Chorus: This can split a mono signal into two channels.  It supplements the sound by adding related components controlled by a depth rate, and 

Delay Pedal: This can add delays of various kinds.

Looper: The final stage in this effects chain.  It can record a loop, store it, dub over that loop, and play loops.  Has a Left and right channel input as well as an Auxillary input.

Mixer:

Recorder:

AltairsSongEDCB
#
00 Just the signal from keyboard, through effects chain, mixer and recorder
01 Compression Pedal

from here on all remaining effects have compression pedal

02 Preamp Pedal mainly used as tone control here

from here on all remaining effects have compression and preamp pedals

03 Fork Lower PEdal a lower octave 
04 fork higher pedal a higher octave
05 Fofk borth pedal with a lower and higher octave
06 chorus
07 Reverse1
08 Reverse2
09 Reverse3

Effects 10-24 all have the same dial parameters on delay pedal
10 Tube Echo
11 Tape Echo
12 Multi head echo
13 Sweep echo
14 Analog echo
15 Analog with Mod echo
16 Low-Res Delay
17 Digital Delay
18 Digital with Mod delay
19 Rhythmic delay
20 stero delay 
21 Ping Pong
22 Reverse 
23 Dynamic Delay
24 Auto volume delay


Extra (Hard shifts)
25 Changing delay time mid-signal
26 changing fork mid-signal  


Equipment Specs
Keyboard: Yamaha
Effects Pedal Power Supply:	Voodoo Powerlabs 24
Effects frame:	Pedal Master??????
Compression Pedal:	Ego Wampler
Preamp:	BB Xotic Preamp
SignalFork:	
Chorus Pedal:
Delay PEdal: Line Six DL4
Looper Pedal: Jammann solo

Mixer:Xenyx 10 input
Recorder: Zoom H4n

Cables, a buch of ??? audio size cables

!
Left channel only compression, preamp,chorus
Right channel delay effects

both through looper to mixer


==========================
CSound
==========================
Comment: Song with sound sources that came from using CSound, a C based synthesizer programming language
Main Point:  Uses tables of wave functions to generate sound in C.
%%%%%%%%%%%%%%%%%%%%%%%%%%

==========================
FrequencyResponseTestMP3s
==========================
Comment: A bit loud.  Similar to that movie starting sound.
Main Point: Plays frequencies from range of ~0 to ~kHz  
%%%%%%%%%%%%%%%%%%%%%%%%%%



==========================
GuitarWAVs
==========================
Comment: 
Main Point: Unedited (except for very end fade out) recording of electric guitar recording with various effects
%%%%%%%%%%%%%%%%%%%%%%%%%%


==========================
Nature Ambient
==========================
Comment: Currently has a sound of a thunderstom.
Main Point:  background ambient sound
%%%%%%%%%%%%%%%%%%%%%%%%%%



==========================
SampleRateBitRateFilesizes(IN HEAVY DEMO ASSETS)
==========================
Comment: I could not really tell significant difference in audio quality over these samples.
This could be due to the audio itself that was being, or the simply no discernable difference.  
Don't really need to listen to much of this.
Main Point: Dealing with various sampling rates and bit depths and impact on file size and quality.
%%%%%%%%%%%%%%%%%%%%%%%%%%
A sample of various sampling rates and bit depths of the same audio 
(Except amsongDelayArching_44khz_EQGauslike).
Sample Rates are 44 kHz, 96 kHz, and 192 kHz 
Bit rates are 16, 24, 32
smallest file size 12.8 MB; amsongDelayArching_44khz_16bit
largest file size 112 MB; amsongDelayArching_192khz_32bit

SR
Sample rates are how many samples per second
44 kHz means 44 thousand samples persecond
(actually 44.1 kHz it is just named 44 kHz)

BD
Bit depth in bits.
Is how many bits per sample
so a 16 bit depth means each sample has 16 bits worth of data

N
Number of channels
mono 1, stereo 2...

t
Time of file in seconds

So a size in bits for a file would be
SR*BD*N*t


Example for song duration of 1 minute and 16 seconds, stereo(two channels),
a bit depth of 16 and sampling rate of 44.1 kHz.

For time, 1 minute is 60 seconds 
so 60 + 16 = 76 seconds

Then using equation: SR*BD*N*t
44,1000 * 16 * 2 * 76 = 107251200 bits 
/ 8 bits per byte
= 13406400 bytes
/ 1024 bytes per kilobyte
= 13092.1875 kilobytes
/ 1024 kilobytes per megabyte
= 12.78533935546875 megabytes

or divide by (8+1024+1024 = 2056)


BR 
Bit Rate which is SR * BD * N which gives the amount of data recorded per second.

==============
ShortSmallMP3s
==============
Comment: Some noise on these recordings.
Main Point: Small amount of data needed for sound samples.
%%%%%%%%%%%%%%
For short duration, small file size MP3s
current average filesize ~24 KB
Keyboard Piano Notes

There is some noise on these recordings



!!!!!!!!!!!!!!!!!!!!!!!!!
Altairs Song effects Demo


Left Channel 
Original	

Right channel
Effects



30_noeffects
31_compression
32_preamp
33_fork-lower
34_fork-higher
35_fork-both

36_chorus

37_reverse_1
38_reverse_2


TEST
39_?
40_Tube Echo 
41 Tape Echo
42_Multi-head
43_Sweep_Echo
44_Analago_Echo
45_Analog w/ Mod
46_LoResDelay
47_Digital DElay
48_Digital w/ Mod
49_Rythmic
TEST


50_stereo delay (and a random note press at 1:15)
51_PingPong
52_Reverse
53_DynamicDelay
54_Auto volume delay

(R)
55_Changing delay time
56_changing fork increases with delay

Left channel only compression, preamp,chorus
Right channel delay effects

both through looper to mixer


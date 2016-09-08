!f5::
WinMove,A,,0,0,845,1040
return

!f6::
WinMove,A,,1155,0,760,627
return

!f7:: 
MouseClick, left,  1124,  107
Sleep, 100
return


!f8::
WinWait, DIM - Google Chrome, 
IfWinNotActive, DIM - Google Chrome, , WinActivate, DIM - Google Chrome, 
WinWaitActive, DIM - Google Chrome, 
MouseClick, left,  451,  13
Sleep, 100
return
## .NET 7.0.0 (7.0.22.42212), X64 RyuJIT
```assembly
; Bench.TrumpMcD()
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       lea       r8,[rsp+28]
       lea       rdx,[rsp+30]
       mov       ecx,7FFFFFFF
       call      qword ptr [7FFD4BBF5DF8]
       nop
       add       rsp,38
       ret
; Total bytes of code 43
```
```assembly
; Bench.TrumpMcDImpl(Int32, Int32 ByRef, Int32 ByRef)
       mov       r9,rdx
       mov       edx,66666667
       mov       eax,edx
       imul      ecx
       mov       eax,edx
       shr       eax,1F
       sar       edx,2
       add       eax,edx
       mov       [r9],eax
       mov       eax,[r9]
       lea       eax,[rax+rax*4]
       add       eax,eax
       sub       ecx,eax
       mov       [r8],ecx
       ret
; Total bytes of code 39
```

## .NET 7.0.0 (7.0.22.42212), X64 RyuJIT
```assembly
; Bench.Spicy()
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       lea       r8,[rsp+28]
       lea       rdx,[rsp+30]
       mov       ecx,7FFFFFFF
       call      qword ptr [7FFD4BC15DC8]
       nop
       add       rsp,38
       ret
; Total bytes of code 43
```
```assembly
; Bench.SpicyImpl(Int32, Int32 ByRef, Int32 ByRef)
       mov       r9,rdx
       mov       edx,66666667
       mov       eax,edx
       imul      ecx
       mov       eax,edx
       shr       eax,1F
       sar       edx,2
       add       eax,edx
       lea       eax,[rax+rax*4]
       add       eax,eax
       mov       edx,ecx
       sub       edx,eax
       mov       [r8],edx
       mov       edx,ecx
       sub       edx,[r8]
       mov       ecx,66666667
       mov       eax,ecx
       imul      edx
       mov       eax,edx
       shr       eax,1F
       sar       edx,2
       add       eax,edx
       mov       [r9],eax
       ret
; Total bytes of code 62
```


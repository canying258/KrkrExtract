# CS_ARCH_ARM, CS_MODE_ARM, None
0xa0,0x03,0xf1,0xf3 = vneg.s8 d16, d16
0xa0,0x03,0xf5,0xf3 = vneg.s16 d16, d16
0xa0,0x03,0xf9,0xf3 = vneg.s32 d16, d16
0xa0,0x07,0xf9,0xf3 = vneg.f32 d16, d16
0xe0,0x03,0xf1,0xf3 = vneg.s8 q8, q8
0xe0,0x03,0xf5,0xf3 = vneg.s16 q8, q8
0xe0,0x03,0xf9,0xf3 = vneg.s32 q8, q8
0xe0,0x07,0xf9,0xf3 = vneg.f32 q8, q8
0xa0,0x07,0xf0,0xf3 = vqneg.s8 d16, d16
0xa0,0x07,0xf4,0xf3 = vqneg.s16 d16, d16
0xa0,0x07,0xf8,0xf3 = vqneg.s32 d16, d16
0xe0,0x07,0xf0,0xf3 = vqneg.s8 q8, q8
0xe0,0x07,0xf4,0xf3 = vqneg.s16 q8, q8
0xe0,0x07,0xf8,0xf3 = vqneg.s32 q8, q8

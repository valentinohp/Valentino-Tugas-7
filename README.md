# Implementasi Optimasi Kinerja Game

## Object Pooling
Dibutuhkan karena mushroom dispawn terus menerus. Apabila terus dibiarkan, komputer akan kehabisan memori. Gunakan Object Pooling untuk menggunakan kembali resource yang ada.

### Before
Memory
![Before_Memory](Screenshot/Before_Memory.png)

Physics
![Before_Physics](Screenshot/Before_Physics.png)

Rendering
![Before_Rendering](Screenshot/Before_Rendering.png)

### After
![AfterPool_Memory](Screenshot/AfterPool_Memory.png)

Physics
![AfterPool_Physics](Screenshot/AfterPool_Physics.png)

Rendering
![AfterPool_Rendering](Screenshot/AfterPool_Rendering.png)

## Optimasi Audio Clip
File audio membutuhkan resource yang cukup besar. Padahal tidak semua clip audio digunakan. Optimasi dilakukan untuk menghemat memory.

### Before
![Before_AudioOn](Screenshot/Before_AudioOn.png)

### After
![After_AudioOn](Screenshot/AfterBGM_AudioOn.png)

## Texture Atlas
Untuk menurunkan jumlah batches dan setpass call, kita bisa menggunakan Texture Atlas. Di kasus ini hanya ada sedikit perubahan, perubahan akan lebih terlihat untuk kasus game yang menggunakan banyak resource 2D.

### Before
![Before_UIStatistics](Screenshot/Before_UIStatistics.png)

### After
![After_UIStatistics](Screenshot/AfterAtlas_UIStatistics.png)

## Static Batching
Terdapat banyak resource statis yang bisa dirender secara batch agar lebih efisien. Namun di kasus saya, penggunaan static batching justru menurunkan performa game. Sehingga untuk masalah ini saya menggunakan GPU Instancing. Hasilnya adalah peningkatan fps dan penurutan jumlah batch.

### Before
![Before_StaticBatching](Screenshot/Before_GPUInstancingStatistics.png)

### After GPU Instancing
![After_GPUInstancing](Screenshot/After_GPUInstancingStatistics.png)

### After Static Batching
![After_StaticBatching](Screenshot/After_StaticBatching.png)
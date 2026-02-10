# Caesar Cipher (Desktop Application)

A Windows Forms (GUI) implementation of the Caesar Cipher algorithm, developed for the INF.04 vocational exam. This application provides a user-friendly interface for encrypting text and saving results to a file.

## Key Features
- **Visual Interface:** Custom styled UI with `CadetBlue` background and `AntiqueWhite` accents.
- **Enhanced Graphics:** Custom-drawn rounded borders for the result field using `GraphicsPath`.
- **Input Validation:** Automatically handles non-integer keys by defaulting the shift to `0`.
- **File Export:** Integrated `SaveFileDialog` for exporting encrypted text to `.txt` files.

## Visual Styling
The application strictly follows the examination design requirements:
- **Background:** `#5F9EA0` (CadetBlue)
- **Labels:** `#FAEBD7` (AntiqueWhite)
- **Result Text:** `#F0F8FF` (AliceBlue)
- **Buttons:** `#ADD8E6` (LightBlue)

## The Logic
The encryption processes only lowercase Latin letters (`a-z`) and preserves spaces, using a robust modulo formula:

$$NewIndex = (CurrentIndex + (Key \bmod 26) + 26) \bmod 26$$

## Screenshots
<p align="left">
  <img src="./assets/gui-demo.gif" width="500" alt="GUI Application Demo">
</p>

## Technical Details
- **Framework:** .NET WinForms
- **Graphics:** `System.Drawing.Drawing2D` for anti-aliased rounded corners.
- **File I/O:** `System.IO` for plaintext file generation.
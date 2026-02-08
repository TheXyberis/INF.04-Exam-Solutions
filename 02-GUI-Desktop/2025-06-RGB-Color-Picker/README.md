# RGB Color Sampler

A desktop application designed for the INF.04 vocational exam. It allows users to interactively mix colors using RGB sliders and "capture" specific values for later reference.

## Features
- **Live Preview:** Large rectangle updates instantly as you move the R, G, and B sliders.
- **Color Capture:** "Save" the current color and its RGB values to a separate preview area.
- **Standard Palette:** Uses exam-compliant colors (Cornsilk background, Peru button).
- **Clean Code:** Implemented with meaningful English naming conventions and DRY (Don't Repeat Yourself) principles.

## Demo
![Application Demo](./assets/app-demo.gif)

## How It Works
1. Adjust the **R, G, and B sliders** (0-255).
2. The **Large Rectangle** and numeric labels update in real-time.
3. Click the **"Save Color"** button to freeze the current color into the small rectangle below.

## Technical Stack
- **Language:** C#
- **Framework:** Windows Forms (.NET)
- **Concepts:** Event-driven programming, RGB color modeling, String interpolation.
# unity-floating-object-system
2 scripts for a lightweight and customizable floating animation component for 2D and 3D objects in Unity.

Ideal for:
- Collectable items
- Power-ups
- Interactive objects
- Decorative environmental elements

---

## ✨ Features

- Adjustable amplitude (float height)
- Adjustable frequency (float speed)
- Custom float direction (axis-based)
- Optional rotation
- Random phase offset (prevents synchronized movement)
- Clean and reusable structure

---

## 📦 Included Scripts

- `FloatingObject3D.cs`
- `FloatingObject2D.cs`

---

## 🎮 How to Use (3D)

1. Attach the script to any GameObject.
2. Adjust from the inspector:
   - Amplitude → how high it floats
   - Frequency → how fast it moves
   - Float Axis → direction of motion
3. (Optional) Enable rotation and set rotation speed.

---

## 🧠 Design Notes

The floating motion uses a sine wave based on `Time.time` to ensure smooth and continuous movement.
A randomized phase offset is applied per instance to avoid identical synchronized animations when multiple objects are present in a scene.

---

## 🚀 Possible Extensions

- Animation curves instead of sine wave
- Editor preview mode
- Bobbing with easing
- Pickup trigger integration
- ScriptableObject presets

---

## 🛠 Unity Version

Tested in Unity6+ (should work in most modern versions).

---

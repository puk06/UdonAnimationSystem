# Udon Animation System

A generic, easy-to-use animation system for Unity `Transform` on **UdonSharp**.  
Animate Unity Canvas UI and 3D GameObjects with the same API.

> **Renamed from Canvas Animation System.** This release is a full rename with no compatibility shim. See [Migration](#-migration-from-canvas-animation-system).

---

## 🌟 Features

- Works with any `Component` or `GameObject` — Canvas UI, 3D objects, and everything with a `Transform`
- Position, rotation, scale, flip, fade, and color animations
- GameObject activation toggles (`Toggle` / `Activate` / `Deactivate`), also schedulable with `after`
- Sequential and delayed animations with easing
- Save / define / reset initial states for smooth transitions
- Fixed-capacity pooled arrays + string task storage: low allocation and stable on Udon
- Works with **UdonSharp** and VRChat Worlds

---

## 🔁 Migration from Canvas Animation System

| Before | After |
| --- | --- |
| `net.puk06.canvas-animation-system` | `net.puk06.udon-animation-system` |
| `net.puk06.UdonAnimation` | `net.puk06.UdonAnimation` |
| `UdonAnimationSystem` | `UdonAnimationSystem` |
| `RectTransformUtils` | `TransformUtils` |
| `Move(..., int pixelOffset, ...)` | `Move(..., float offset, ...)` |

Update namespaces and the component type name in your scripts and scenes. There is no `UdonAnimationSystem` alias in this version.

---

## 📖 Documentation

> **Note:** The Wiki for this project is still in progress. The API is almost identical to UdonAnimationSystem, so refer to the [UdonAnimationSystem Wiki](https://github.com/puk06/UdonAnimationSystem/wiki) for usage details. Apply the renames listed in [Migration](#-migration-from-canvas-animation-system).

Detailed setup instructions, API reference, and examples are available in the [Wiki](https://github.com/puk06/UdonAnimationSystem/wiki).

📚 **Wiki Sections:**
- [Getting Started](https://github.com/puk06/UdonAnimationSystem/wiki/Getting-Started)
- [Available Methods](https://github.com/puk06/UdonAnimationSystem/wiki/Available-Methods)

---

## 📄 License

See [LICENSE](LICENSE).

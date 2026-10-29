# Udon Animation System

A generic, easy-to-use animation system for Unity `Transform` on **UdonSharp**.  
Animate Unity Canvas UI and 3D GameObjects with the same API.

> **Renamed from Canvas Animation System.** This release is a full rename with no compatibility shim. See [Migration](#-migration-from-canvas-animation-system).

---

## 🌟 Features

- Works with any `Component` or `GameObject` — Canvas UI, 3D objects, and everything with a `Transform`
- Position, rotation, scale, flip, fade, and color animations
- Sequential and delayed animations with easing
- Save / define / reset initial states for smooth transitions
- Fixed-capacity pooled arrays + string task storage: low allocation and stable on Udon
- Works with **UdonSharp** and VRChat Worlds

---

## 📦 Installation

Install the package through your VPM listing:

```
https://github.com/puk06/CanvasAnimationSystem/releases/download/v0.4.0/net.puk06.udon-animation-system-v0.4.0.zip?
```

Requirements:
- Unity 2022.3
- VRChat Worlds (`com.vrchat.worlds`) 3.5.0 or later
- [`net.puk06.udon-utils`](https://github.com/puk06/UdonUtils) 1.0.0 or later

---

## 🚀 Quick Start

1. Add `UdonAnimationSystem` to a GameObject.
2. Reference it from your UdonSharp behaviour.
3. Pass a `Component`, `Transform`, or `GameObject` to the animation methods.

```csharp
using net.puk06.UdonAnimation;
using net.puk06.UdonAnimation.Models;
using UdonSharp;
using UnityEngine;

public class AnimationExample : UdonSharpBehaviour
{
    public UdonAnimationSystem animations;
    public GameObject cube;
    public Transform target;
    public UnityEngine.UI.Image panel;

    void Start()
    {
        // 3D GameObject: move in from below, rotate, and scale up.
        animations
            .Move(cube, 0.3f, 0f, 0.5f, MoveDirection.Up, TransitionType.EaseOut)
            .Rotate(target, 0.5f, 0f, AnimationDirection.To, new Vector3(0f, 180f, 0f), TransitionType.EaseInOut)
            .Scale(cube, 0.3f, 0f, AnimationDirection.To, Vector3.one * 1.5f, TransitionType.EaseOut);

        // UI: fade in and change color.
        animations
            .Fade(panel, 0.25f, 0f, FadeType.In, TransitionType.Linear)
            .Color(panel, 0.5f, 0f, AnimationDirection.To, Color.red, TransitionType.EaseInOut);
    }
}
```

### Supported targets

All Transform-based methods accept both `Component` and `GameObject`, including arrays:

```csharp
animations.Move(component, ...);      // any Component on the object
animations.Move(transform, ...);      // Transform is a Component
animations.Move(gameObject, ...);     // GameObject overload
animations.Move(gameObjects, ...);    // GameObject[]
animations.Move(components, ...);     // Component[]
```

`Fade`, `Show`, `Hide`, and `Color` remain UI-specific and accept these components:
`Text`, `Button`, `Image`, `RawImage`, and `TMP_Text`.

---

## 📐 Coordinate Space

Position, rotation, and scale are applied in **local space** (`localPosition`, `localEulerAngles`, `localScale`). This is the same behaviour as the previous Canvas-only version.

The `offset` parameter of `Move` / `MoveTo` is now a `float` in local units. For Canvas UI at scale 1 this is effectively pixels; for 3D objects it is world-scale units.

---

## 💾 Save / Define / Reset

```csharp
using net.puk06.UdonAnimation.Models;

// Store the current transform as the animation's starting point.
animations.SaveTransform(cube, new TransformType[] {
    TransformType.Position,
    TransformType.Rotation,
    TransformType.Scale
});

// Or set an explicit initial value.
animations.DefineTransform(cube, Vector3.zero, TransformType.Position);

// Restore the saved value later.
animations.ResetTransform(cube, new TransformType[] { TransformType.Position });
```

Definitions are keyed by the object's `Transform`, so a definition created with a `GameObject` can be used by a `Component` on the same object (and vice versa).  
`Cancel(element)` / `RemoveDefine(element)` also operate on the object's `Transform`, so they affect all animations and definitions on the same GameObject.

---

## 🔁 Migration from Canvas Animation System

| Before (v0.3.0) | After (v0.4.0) |
| --- | --- |
| `net.puk06.canvas-animation-system` | `net.puk06.udon-animation-system` |
| `net.puk06.CanvasAnimation` | `net.puk06.UdonAnimation` |
| `CanvasAnimationSystem` | `UdonAnimationSystem` |
| `RectTransformUtils` | `TransformUtils` |
| `Move(..., int pixelOffset, ...)` | `Move(..., float offset, ...)` |

Update namespaces and the component type name in your scripts and scenes. There is no `CanvasAnimationSystem` alias in this version.

---

## 📖 Documentation

Detailed setup instructions, API reference, and examples are available in the [Wiki](https://github.com/puk06/CanvasAnimationSystem/wiki).

📚 **Wiki Sections:**
- [Getting Started](https://github.com/puk06/CanvasAnimationSystem/wiki/Getting-Started)
- [Available Methods](https://github.com/puk06/CanvasAnimationSystem/wiki/Available-Methods)

---

## 📄 License

See [LICENSE](LICENSE).

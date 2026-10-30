# Udon Animation System

A generic, easy-to-use animation system for Unity `Transform` on **UdonSharp**.  
Animate Unity Canvas UI and 3D GameObjects with the same API.

> **Renamed from Canvas Animation System.** This release is a full rename with no compatibility shim. See [Migration](#-migration-from-canvas-animation-system).

---

## 🌟 Features

- Works with any `Component` or `GameObject` — Canvas UI, 3D objects, and everything with a `Transform`
- Position, rotation, scale, flip, fade, and color animations
- GameObject activation toggles (`Toggle` / `Activate` / `Deactivate`), also schedulable with `after`
- Custom callback receivers (`SetCustomReceiver`) that receive eased progress while an animation runs
- Sequential and delayed animations with easing
- Save / define / reset initial states for smooth transitions
- Fixed-capacity pooled arrays + string task storage: low allocation and stable on Udon
- Works with **UdonSharp** and VRChat Worlds

---

## 🎛 Custom Receiver

`SetCustomReceiver` drives any UdonSharp behaviour with the same timing and easing pipeline as the built-in animations.

Inherit from `UdonAnimationCallbackReceiver`:

```csharp
using net.puk06.UdonAnimation;
using UdonSharp;

public class MyReceiver : UdonAnimationCallbackReceiver
{
    public override void OnAnimationUpdate(string identifier, float eased)
    {
        // Called every frame. eased is 0 -> 1 with the selected TransitionType applied.
    }

    public override void OnAnimationComplete(string identifier)
    {
        // Called once when the animation finishes.
    }
}
```

Then pass it to the animation system:

```csharp
using net.puk06.UdonAnimation.Models;

animationSystem.SetCustomReceiver(receiver, 1f, 0f, TransitionType.EaseOut, "open");
```

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

VfxExtra
========

**VfxExtra** is a collection of utilities for Unity Visual Effect Graph.

At the moment, it only contains property/event binder classes for the [new
Input System].

[new Input System]:
    https://blogs.unity3d.com/2019/10/14/introducing-the-new-input-system/

![screenshot](https://i.imgur.com/HHfxX5dm.jpg)

### Property binders

VFXInputValueBinder -- Binds a value (axis, button pressure, etc.) of an
InputAction to a VFX property.

VFXPlayerInputValueBinder -- Retrieves a value of an action from a PlayerInput
and binds it to a VFX property.

### Event binders

VFXInputEventBinder -- Sends a VFX event on an InputAction.

VFXPlayerInputEventBinder -- Receives an action from a PlayerInput and sends a
VFX event.

How To Install
--------------

This package uses the [scoped registry] feature to resolve package
dependencies. Please add the following sections to the manifest file
(Packages/manifest.json).

[scoped registry]: https://docs.unity3d.com/Manual/upm-scoped.html

To the `scopedRegistries` section:

```
{
  "name": "Keijiro",
  "url": "https://registry.npmjs.com",
  "scopes": [ "jp.keijiro" ]
}
```

To the `dependencies` section:

```
"jp.keijiro.vfx-extra": "1.0.0"
```

After changes, the manifest file should look like below:

```
{
  "scopedRegistries": [
    {
      "name": "Keijiro",
      "url": "https://registry.npmjs.com",
      "scopes": [ "jp.keijiro" ]
    }
  ],
  "dependencies": {
    "jp.keijiro.vfx-extra": "1.0.0",
    ...
```

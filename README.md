<h1 align="center">NovaUtils</h1>
<p align="center">A collection of utility classes and methods for use in Unity projects.</p>

<p align="center">
 <a href="https://github.com/NovaDawn-Studios/NovaUtils/stargazers">
  <img src="https://img.shields.io/github/stars/NovaDawn-Studios/NovaUtils?color=FFD700" alt="GitHub Repo Stars" />
 </a>
 <a href="https://github.com/NovaDawn-Studios/NovaUtils/graphs/contributors">
  <img src="https://img.shields.io/github/contributors-anon/NovaDawn-Studios/NovaUtils?color=009a00" alt="GitHub Contributors" />
 </a>
 <a href="https://github.com/NovaDawn-Studios/NovaUtils/commits/main">
  <img src="https://img.shields.io/github/last-commit/NovaDawn-Studios/NovaUtils" alt="Latest Commit" />
 </a>
</p>

----

**_Note: This product isn't ready or usable yet, but the documentation below corresponds with the overall plans of the project. Once it's in a workable state, this message will disappear._**

----

NovaUtils is a collection of disparate utilities designed to improve the development experience of Unity projects. This includes such things as

* **Advanced Gizmos** - An extended set of Editor gizmos useful for certain features, such as showing the silhouette of a person.
* **Extension Methods** - Provides a number of extension methods to various types, simplifying operations common to game development. This includes things such as:
  * Get a random element from a collection.


_Note: Examples are available in the [Samples](https://github.com/NovaDawn-Studios/NovaUtils/tree/main/Samples~) folder_

## Installing NovaUtils

To install NovaUtils in your project, you will need to use the Unity Package Manager.

To open the Unity Package Manager, in Unity, first go to Window -> Package Manager, then click the small + icon at the top left of the window that pops up and click 'Install package from git URL...'. In the window that pops up, paste in https://github.com/NovaDawn-Studios/NovaUtils.git and you should be good to go.

## Using NovaUtils

When installed, all of NovaUtils functionality will be available once you add

```csharp
using NovaDawnStudios.NovaUtils;
```

or

```csharp
using NovaDawnStudios.NovaUtils.Editor;
```

to the top of your code files. This includes adding extension methods and utility types.

**_TODO: Provide more details._**

## Contributing

Are we missing a feature? Find a bug? Just want to contribute? Go ahead! Raise issues, create PRs, spread the word. If your code gets added and is used in a NovaDawn Studios game, you'll even appear in the credits (Unless you don't want to be, of course)!

# FontAwesomeCS
C# mappings to FontAwesome 5+

## Installation

### As a NuGet package

(TODO)

```ps
Install-Package FontAwesomeCS
```

### As a single file

Copy-paste the generated output into your project from here: https://raw.githubusercontent.com/flyingpie/FontAwesomeCS/master/FontAwesomeCS.SingleFile/FontAwesomeCS.cs

## Usage

FontAwesomeCS generates an enum with attributes like this:

```cs
public enum FAIcon
{
...
  [FAIcon("github", FAStyle.Brands, "\uf09b")] GithubBrands,
  [FAIcon("github-alt", FAStyle.Brands, "\uf113")] GithubAltBrands,
  [FAIcon("github-square", FAStyle.Brands, "\uf092")] GithubSquareBrands,
...
}
```

Using a couple of built-in extensions, you can use these to get to the metadata:

```cs
// "github-alt"
var key = FAIcon.GithubAltBrands.Key();

// "Alternate GitHub"
var label = FAIcon.GithubAltBrands.Label();

// "\uf113"
var unicode = FAIcon.GithubAltBrands.Unicode();

// "brands"
var style = FAIcon.GithubAltBrands.Style();
```

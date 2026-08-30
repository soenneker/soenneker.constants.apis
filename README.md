[![](https://img.shields.io/nuget/v/soenneker.constants.apis.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.constants.apis/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.constants.apis/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.constants.apis/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.constants.apis.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.constants.apis/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.constants.apis/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.constants.apis/actions/workflows/codeql.yml)

# Soenneker.Constants.Apis

Provides the shared `HttpContext.Items` key used to mark requests that reached an MVC controller.

## Install

```bash
dotnet add package Soenneker.Constants.Apis
```

## Usage

```csharp
using Soenneker.Constants.Apis;

httpContext.Items[ApiConstants.ControllerHitFlag] = true;

bool reachedController = httpContext.Items.ContainsKey(ApiConstants.ControllerHitFlag);
```

`ControllerHitFlag` has the literal value `"ControllerHitFlag"`. It is intended as an items-dictionary key; the associated value is conventionally `true`, but consumers generally only test whether the key is present.

This allows independently packaged middleware and filters to communicate without duplicating a magic string. `HttpContext.Items` is scoped to one request, so the marker is not shared across requests or persisted.

# wsdlserviceapp
Trying to get WsdlService running on netstandard

1. Clone this repo.
2. Run .paket/paket.bootstrapper.exe
3. Run dotnet build (it should run paket for you)

Build fails for netcoreapp2.0:
![build fails for netcoreapp2.0](https://user-images.githubusercontent.com/2267030/34543410-ad0e0bce-f0ae-11e7-85b0-0aa5c72031e7.png)

Build works for net461
![build works for net461](https://user-images.githubusercontent.com/2267030/34543456-de0d7c32-f0ae-11e7-80d8-ecf2094e0c29.png)

In both cases intellisense has no problems on VS Code with Ionide & VS 2017 (15.5.2) so I am pretty sure I properly applied the workaround from https://github.com/Microsoft/visualfsharp/issues/3303#issuecomment-312966306.

Maybe the Type Providers in FSharp.Data.TypeProviders are not "cross targeting" per https://github.com/Microsoft/visualfsharp/issues/3303#issuecomment-312966306, but I do not know how to verify that. The "cross-targeting" link is broken in the comment.

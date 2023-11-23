using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;

namespace Blazor8Auth.Components;

[Authorize]
public class MyComponentBase : ComponentBase
{
}

using DataAccess.DataAccess;
using MainModule.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace MainModule.Endpoints;

public static class MemberEndpoint
{
    public static void MapMemberEndpoints(this WebApplication app)
    {
        app.MapPost("/api/createMember", CreateMemberAsync);
    }

    private static async Task<IResult> CreateMemberAsync([FromBody] MemberDto dto,
                                                        [FromServices] MemberData memberData)
    {
        return await memberData.CreateMember<MemberDto, MemberDto>(dto) != null ? Results.Ok(dto) :
            Results.BadRequest("Failed to create member");
    }
}

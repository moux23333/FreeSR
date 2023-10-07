namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class StartCocoonStageCsReq
	{
		[ProtoMember(13)] public int PropEntityId;
		[ProtoMember(3)] public int WorldLevel;
		[ProtoMember(11)] public int CocoonId;
		[ProtoMember(7)] public int Wave;
	}

}

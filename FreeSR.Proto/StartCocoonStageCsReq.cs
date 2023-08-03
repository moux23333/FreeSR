namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class StartCocoonStageCsReq
	{
		[ProtoMember(3)] public int Wave;
		[ProtoMember(8)] public int CocoonId;
		[ProtoMember(4)] public int WorldLevel;
		[ProtoMember(1)] public int PropEntityId;
	}
	
}

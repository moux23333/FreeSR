namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class EnhanceRogueBuffCsReq
	{
		[ProtoMember(1)] public int MazeBuffId;
	}
	
}

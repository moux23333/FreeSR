namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SelectRogueBuffCsReq
	{
		[ProtoMember(11)] public int MazeBuffId;
	}
	
}

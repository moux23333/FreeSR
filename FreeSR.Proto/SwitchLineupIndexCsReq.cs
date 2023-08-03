namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SwitchLineupIndexCsReq
	{
		[ProtoMember(13)] public int Index;
	}
	
}

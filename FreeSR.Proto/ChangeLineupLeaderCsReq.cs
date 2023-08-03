namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ChangeLineupLeaderCsReq
	{
		[ProtoMember(7)] public int Slot;
	}
	
}

namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ChangeLineupLeaderCsReq
	{
		[ProtoMember(9)] public List<int> Slot;
	}

}
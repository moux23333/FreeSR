namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ChangeLineupLeaderScRsp
	{
		[ProtoMember(7)] public List<int> Slot;
        [ProtoMember(10)] public int Retcode;
	}

}
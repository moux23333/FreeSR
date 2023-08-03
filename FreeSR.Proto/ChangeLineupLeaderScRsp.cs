namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ChangeLineupLeaderScRsp
	{
		[ProtoMember(12)] public int Slot;
		[ProtoMember(15)] public int Retcode;
	}
	
}

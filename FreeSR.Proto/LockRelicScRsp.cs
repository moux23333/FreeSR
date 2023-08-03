namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class LockRelicScRsp
	{
		[ProtoMember(7)] public int Retcode;
		[ProtoMember(9)] public int RelicUniqueId;
	}
	
}

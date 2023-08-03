namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class LeaveRaidScRsp
	{
		[ProtoMember(12)] public int Retcode;
	}
	
}

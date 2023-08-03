namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class StartRaidScRsp
	{
		[ProtoMember(11)] public int Retcode;
	}
	
}

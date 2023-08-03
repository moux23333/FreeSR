namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SpringRecoverScRsp
	{
		[ProtoMember(13)] public int Retcode;
		[ProtoMember(9)] public HealPoolInfo HealPoolInfo;
	}
	
}

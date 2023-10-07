namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SpringRecoverScRsp
	{
		[ProtoMember(7)] public HealPoolInfo HealPoolInfo;
		[ProtoMember(8)] public int Retcode;
	}

}

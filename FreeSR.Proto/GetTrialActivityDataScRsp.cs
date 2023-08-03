namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetTrialActivityDataScRsp
	{
		[ProtoMember(15)] public int EONOLLBLAFM;
		[ProtoMember(14)] public int Retcode;
		[ProtoMember(3)] public List<PNFBKDNNCCG> MOMFLLKMDDC;
	}
	
}

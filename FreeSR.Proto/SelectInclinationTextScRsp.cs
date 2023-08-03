namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SelectInclinationTextScRsp
	{
		[ProtoMember(4)] public int Retcode;
		[ProtoMember(3)] public int FKOEIEGALCE;
	}
	
}

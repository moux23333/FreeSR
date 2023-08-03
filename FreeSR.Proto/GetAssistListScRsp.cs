namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetAssistListScRsp
	{
		[ProtoMember(3)] public List<BOAAGILBGJA> DHLCDINCAHC;
		[ProtoMember(15)] public int Retcode;
	}
	
}

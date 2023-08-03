namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetShareDataScRsp
	{
		[ProtoMember(6)] public int Retcode;
		[ProtoMember(1)] public List<PFDBIHBKPAP> PHAJDGHACEI;
	}
	
}

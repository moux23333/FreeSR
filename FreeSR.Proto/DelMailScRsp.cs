namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class DelMailScRsp
	{
		[ProtoMember(14)] public int Retcode;
		[ProtoMember(9)] public List<int> IdList;
	}

}

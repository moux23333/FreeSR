namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class DelMailScRsp
	{
		[ProtoMember(13)] public List<int> IdList;
		[ProtoMember(14)] public int Retcode;
	}
	
}

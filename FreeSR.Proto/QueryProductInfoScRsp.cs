namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class QueryProductInfoScRsp
	{
		[ProtoMember(10)] public int Retcode;
		[ProtoMember(13)] public long CBOLAPOCOEI;
		[ProtoMember(9)] public List<Product> ProductList;
	}
	
}

namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class DestroyItemScRsp
	{
		[ProtoMember(13)] public int Retcode;
		[ProtoMember(2)] public int GDEPAGDJBNB;
	}
	
}

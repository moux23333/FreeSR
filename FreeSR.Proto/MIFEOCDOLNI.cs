namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class MIFEOCDOLNI
	{
		[ProtoMember(14)] public int Retcode;
		[ProtoMember(15)] public List<CHNHKPPKDIN> Pinlbbpcbkn;
	}

}

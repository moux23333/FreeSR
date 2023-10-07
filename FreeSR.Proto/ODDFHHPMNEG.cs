namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ODDFHHPMNEG
	{
		[ProtoMember(7)] public int Retcode;
		[ProtoMember(4)] public int Progress;
		[ProtoMember(8)] public int Lfcdbedkeom;
	}

}

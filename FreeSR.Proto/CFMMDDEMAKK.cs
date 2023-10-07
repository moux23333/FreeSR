namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class CFMMDDEMAKK
	{
		[ProtoMember(5)] public int Retcode;
		[ProtoMember(15)] public int Index;
		[ProtoMember(7)] public string Name;
	}

}

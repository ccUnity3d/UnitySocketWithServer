//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Inner/SystemProto.proto
namespace ProtoBuf
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RequestAlive")]
  public partial class RequestAlive : global::ProtoBuf.IExtensible
  {
    public RequestAlive() {}
    
    private int _proto;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"proto", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int proto
    {
      get { return _proto; }
      set { _proto = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ResponseAlive")]
  public partial class ResponseAlive : global::ProtoBuf.IExtensible
  {
    public ResponseAlive() {}
    
    private int _proto;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"proto", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int proto
    {
      get { return _proto; }
      set { _proto = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PlayerInfo")]
  public partial class PlayerInfo : global::ProtoBuf.IExtensible
  {
    public PlayerInfo() {}
    
    private string _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string id
    {
      get { return _id; }
      set { _id = value; }
    }
    private string _account;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"account", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string account
    {
      get { return _account; }
      set { _account = value; }
    }
    private string _username;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"username", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string username
    {
      get { return _username; }
      set { _username = value; }
    }
    private string _passwrod;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"passwrod", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string passwrod
    {
      get { return _passwrod; }
      set { _passwrod = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RequestRegister")]
  public partial class RequestRegister : global::ProtoBuf.IExtensible
  {
    public RequestRegister() {}
    
    private int _proto;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"proto", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int proto
    {
      get { return _proto; }
      set { _proto = value; }
    }
    private string _account;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"account", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string account
    {
      get { return _account; }
      set { _account = value; }
    }
    private string _username;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"username", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string username
    {
      get { return _username; }
      set { _username = value; }
    }
    private string _password;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"password", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string password
    {
      get { return _password; }
      set { _password = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ResponseRegister")]
  public partial class ResponseRegister : global::ProtoBuf.IExtensible
  {
    public ResponseRegister() {}
    
    private int _proto;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"proto", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int proto
    {
      get { return _proto; }
      set { _proto = value; }
    }
    private string _error = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"error", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string error
    {
      get { return _error; }
      set { _error = value; }
    }
    private PlayerInfo _player_info = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"player_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public PlayerInfo player_info
    {
      get { return _player_info; }
      set { _player_info = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RequestLogin")]
  public partial class RequestLogin : global::ProtoBuf.IExtensible
  {
    public RequestLogin() {}
    
    private int _proto;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"proto", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int proto
    {
      get { return _proto; }
      set { _proto = value; }
    }
    private string _account;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"account", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string account
    {
      get { return _account; }
      set { _account = value; }
    }
    private string _password;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"password", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string password
    {
      get { return _password; }
      set { _password = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ResponseLogin")]
  public partial class ResponseLogin : global::ProtoBuf.IExtensible
  {
    public ResponseLogin() {}
    
    private int _proto;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"proto", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int proto
    {
      get { return _proto; }
      set { _proto = value; }
    }
    private string _error = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"error", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string error
    {
      get { return _error; }
      set { _error = value; }
    }
    private string _result = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string result
    {
      get { return _result; }
      set { _result = value; }
    }
    private PlayerInfo _player;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"player", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public PlayerInfo player
    {
      get { return _player; }
      set { _player = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GameRoomInfo")]
  public partial class GameRoomInfo : global::ProtoBuf.IExtensible
  {
    public GameRoomInfo() {}
    
    private string _room_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"room_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string room_id
    {
      get { return _room_id; }
      set { _room_id = value; }
    }
    private string _room_name;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"room_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string room_name
    {
      get { return _room_name; }
      set { _room_name = value; }
    }
    private string _password = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"password", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string password
    {
      get { return _password; }
      set { _password = value; }
    }
    private int _player_number = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"player_number", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int player_number
    {
      get { return _player_number; }
      set { _player_number = value; }
    }
    private bool _can_watch = default(bool);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"can_watch", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool can_watch
    {
      get { return _can_watch; }
      set { _can_watch = value; }
    }
    private string _player_id;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"player_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string player_id
    {
      get { return _player_id; }
      set { _player_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RequestCreateRoom")]
  public partial class RequestCreateRoom : global::ProtoBuf.IExtensible
  {
    public RequestCreateRoom() {}
    
    private int _proto;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"proto", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int proto
    {
      get { return _proto; }
      set { _proto = value; }
    }
    private string _room_name;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"room_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string room_name
    {
      get { return _room_name; }
      set { _room_name = value; }
    }
    private string _password;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"password", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string password
    {
      get { return _password; }
      set { _password = value; }
    }
    private bool _can_watch;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"can_watch", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool can_watch
    {
      get { return _can_watch; }
      set { _can_watch = value; }
    }
    private int _player_number;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"player_number", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int player_number
    {
      get { return _player_number; }
      set { _player_number = value; }
    }
    private string _player_id;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"player_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string player_id
    {
      get { return _player_id; }
      set { _player_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ResponseCreateRoom")]
  public partial class ResponseCreateRoom : global::ProtoBuf.IExtensible
  {
    public ResponseCreateRoom() {}
    
    private int _proto;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"proto", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int proto
    {
      get { return _proto; }
      set { _proto = value; }
    }
    private string _error = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"error", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string error
    {
      get { return _error; }
      set { _error = value; }
    }
    private GameRoomInfo _room = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"room", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public GameRoomInfo room
    {
      get { return _room; }
      set { _room = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RequestGetRooms")]
  public partial class RequestGetRooms : global::ProtoBuf.IExtensible
  {
    public RequestGetRooms() {}
    
    private int _proto;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"proto", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int proto
    {
      get { return _proto; }
      set { _proto = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ResponseGetRooms")]
  public partial class ResponseGetRooms : global::ProtoBuf.IExtensible
  {
    public ResponseGetRooms() {}
    
    private int _proto;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"proto", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int proto
    {
      get { return _proto; }
      set { _proto = value; }
    }
    private readonly global::System.Collections.Generic.List<GameRoomInfo> _rooms = new global::System.Collections.Generic.List<GameRoomInfo>();
    [global::ProtoBuf.ProtoMember(2, Name=@"rooms", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<GameRoomInfo> rooms
    {
      get { return _rooms; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RequestDeleteRoom")]
  public partial class RequestDeleteRoom : global::ProtoBuf.IExtensible
  {
    public RequestDeleteRoom() {}
    
    private int _proto;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"proto", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int proto
    {
      get { return _proto; }
      set { _proto = value; }
    }
    private int _room_id;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"room_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int room_id
    {
      get { return _room_id; }
      set { _room_id = value; }
    }
    private string _player_id;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"player_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string player_id
    {
      get { return _player_id; }
      set { _player_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ResponseDeleteRoom")]
  public partial class ResponseDeleteRoom : global::ProtoBuf.IExtensible
  {
    public ResponseDeleteRoom() {}
    
    private int _proto;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"proto", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int proto
    {
      get { return _proto; }
      set { _proto = value; }
    }
    private string _error = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"error", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string error
    {
      get { return _error; }
      set { _error = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RequestJoinRoom")]
  public partial class RequestJoinRoom : global::ProtoBuf.IExtensible
  {
    public RequestJoinRoom() {}
    
    private int _proto;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"proto", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int proto
    {
      get { return _proto; }
      set { _proto = value; }
    }
    private string _player_id;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"player_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string player_id
    {
      get { return _player_id; }
      set { _player_id = value; }
    }
    private int _room_id;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"room_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int room_id
    {
      get { return _room_id; }
      set { _room_id = value; }
    }
    private string _password;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"password", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string password
    {
      get { return _password; }
      set { _password = value; }
    }
    private bool _is_watch;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"is_watch", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool is_watch
    {
      get { return _is_watch; }
      set { _is_watch = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ResponseJoinRoom")]
  public partial class ResponseJoinRoom : global::ProtoBuf.IExtensible
  {
    public ResponseJoinRoom() {}
    
    private int _proto;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"proto", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int proto
    {
      get { return _proto; }
      set { _proto = value; }
    }
    private string _error;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"error", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string error
    {
      get { return _error; }
      set { _error = value; }
    }
    private GameRoomInfo _room;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"room", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public GameRoomInfo room
    {
      get { return _room; }
      set { _room = value; }
    }
    private string _players;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"players", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string players
    {
      get { return _players; }
      set { _players = value; }
    }
    private string _watch_players;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"watch_players", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string watch_players
    {
      get { return _watch_players; }
      set { _watch_players = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RequestExitRoom")]
  public partial class RequestExitRoom : global::ProtoBuf.IExtensible
  {
    public RequestExitRoom() {}
    
    private int _proto;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"proto", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int proto
    {
      get { return _proto; }
      set { _proto = value; }
    }
    private string _player_id;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"player_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string player_id
    {
      get { return _player_id; }
      set { _player_id = value; }
    }
    private int _room_id;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"room_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int room_id
    {
      get { return _room_id; }
      set { _room_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ResponseExitRoom")]
  public partial class ResponseExitRoom : global::ProtoBuf.IExtensible
  {
    public ResponseExitRoom() {}
    
    private int _proto;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"proto", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int proto
    {
      get { return _proto; }
      set { _proto = value; }
    }
    private string _error;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"error", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string error
    {
      get { return _error; }
      set { _error = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"CmdEnum")]
    public enum CmdEnum
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"Req_Alive", Value=100000)]
      Req_Alive = 100000,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Req_Register", Value=100001)]
      Req_Register = 100001,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Req_Login", Value=100002)]
      Req_Login = 100002,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Req_CreateRoom", Value=100003)]
      Req_CreateRoom = 100003,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Req_GetRooms", Value=100004)]
      Req_GetRooms = 100004,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Req_DeleteRoom", Value=100005)]
      Req_DeleteRoom = 100005,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Res_Alive", Value=200000)]
      Res_Alive = 200000,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Res_Register", Value=200001)]
      Res_Register = 200001,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Res_Login", Value=200002)]
      Res_Login = 200002,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Res_CreateRoom", Value=200003)]
      Res_CreateRoom = 200003,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Res_GetRooms", Value=200004)]
      Res_GetRooms = 200004,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Res_DeleteRoom", Value=200005)]
      Res_DeleteRoom = 200005
    }
  
}
﻿namespace Domain.Tests;

public class _3_Errors
{
    private readonly NonSenseService _nonSenseService = new();

    [Theory]
    [InlineData("1", "1")]
    [InlineData("2", "2")]
    [InlineData("3", "FooFoo")]
    [InlineData("4", "4")]
    [InlineData("5", "BarBar")]
    [InlineData("6", "Foo")]
    [InlineData("7", "QixQix")]
    [InlineData("8", "8")]
    [InlineData("9", "Foo")]
    [InlineData("10", "Bar")]
    [InlineData("11", "11")]
    [InlineData("12", "Foo")]
    [InlineData("13", "Foo")]
    [InlineData("14", "Qix")]
    [InlineData("15", "FooBarBar")]
    [InlineData("16", "16")]
    [InlineData("17", "Qix")]
    [InlineData("18", "Foo")]
    [InlineData("19", "19")]
    [InlineData("20", "Bar")]
    [InlineData("21", "FooQix")]
    [InlineData("22", "22")]
    [InlineData("23", "Foo")]
    [InlineData("24", "Foo")]
    [InlineData("25", "BarBar")]
    [InlineData("26", "26")]
    [InlineData("27", "FooQix")]
    [InlineData("28", "Qix")]
    [InlineData("29", "29")]
    [InlineData("30", "FooBarFoo")]
    [InlineData("31", "Foo")]
    [InlineData("32", "Foo")]
    [InlineData("33", "FooFooFoo")]
    [InlineData("34", "Foo")]
    [InlineData("35", "BarQixFooBar")]
    [InlineData("36", "FooFoo")]
    [InlineData("37", "FooQix")]
    [InlineData("38", "Foo")]
    [InlineData("39", "FooFoo")]
    [InlineData("40", "Bar")]
    [InlineData("41", "41")]
    [InlineData("42", "FooQix")]
    [InlineData("43", "Foo")]
    [InlineData("44", "44")]
    [InlineData("45", "FooBarBar")]
    [InlineData("46", "46")]
    [InlineData("47", "Qix")]
    [InlineData("48", "Foo")]
    [InlineData("49", "Qix")]
    [InlineData("50", "BarBar")]
    [InlineData("51", "FooBar")]
    [InlineData("52", "Bar")]
    [InlineData("53", "BarFoo")]
    [InlineData("54", "FooBar")]
    [InlineData("55", "BarBarBar")]
    [InlineData("56", "QixBar")]
    [InlineData("57", "FooBarQix")]
    [InlineData("58", "Bar")]
    [InlineData("59", "Bar")]
    [InlineData("60", "FooBar")]
    [InlineData("61", "61")]
    [InlineData("62", "62")]
    [InlineData("63", "FooQixFoo")]
    [InlineData("64", "64")]
    [InlineData("65", "BarBar")]
    [InlineData("66", "Foo")]
    [InlineData("67", "Qix")]
    [InlineData("68", "68")]
    [InlineData("69", "Foo")]
    [InlineData("70", "BarQixQix")]
    [InlineData("71", "Qix")]
    [InlineData("72", "FooQix")]
    [InlineData("73", "QixFoo")]
    [InlineData("74", "Qix")]
    [InlineData("75", "FooBarQixBar")]
    [InlineData("76", "Qix")]
    [InlineData("77", "QixQixQix")]
    [InlineData("78", "FooQix")]
    [InlineData("79", "Qix")]
    [InlineData("80", "Bar")]
    [InlineData("81", "Foo")]
    [InlineData("82", "82")]
    [InlineData("83", "Foo")]
    [InlineData("84", "FooQix")]
    [InlineData("85", "BarBar")]
    [InlineData("86", "86")]
    [InlineData("87", "FooQix")]
    [InlineData("88", "88")]
    [InlineData("89", "89")]
    [InlineData("90", "FooBar")]
    [InlineData("91", "Qix")]
    [InlineData("92", "92")]
    [InlineData("93", "FooFoo")]
    [InlineData("94", "94")]
    [InlineData("95", "BarBar")]
    [InlineData("96", "Foo")]
    [InlineData("97", "Qix")]
    [InlineData("98", "Qix")]
    [InlineData("99", "Foo")]
    [InlineData("100", "Bar")]
    [InlineData("101", "101")]
    [InlineData("102", "Foo")]
    [InlineData("103", "Foo")]
    [InlineData("104", "104")]
    [InlineData("105", "FooBarQixBar")]
    [InlineData("106", "106")]
    [InlineData("107", "Qix")]
    [InlineData("108", "Foo")]
    [InlineData("109", "109")]
    [InlineData("110", "Bar")]
    [InlineData("111", "Foo")]
    [InlineData("112", "Qix")]
    [InlineData("113", "Foo")]
    [InlineData("114", "Foo")]
    [InlineData("115", "BarBar")]
    [InlineData("116", "116")]
    [InlineData("117", "FooQix")]
    [InlineData("118", "118")]
    [InlineData("119", "Qix")]
    [InlineData("120", "FooBar")]
    [InlineData("121", "121")]
    [InlineData("122", "122")]
    [InlineData("123", "FooFoo")]
    [InlineData("124", "124")]
    [InlineData("125", "BarBar")]
    [InlineData("126", "FooQix")]
    [InlineData("127", "Qix")]
    [InlineData("128", "128")]
    [InlineData("129", "Foo")]
    [InlineData("130", "BarFoo")]
    [InlineData("131", "Foo")]
    [InlineData("132", "FooFoo")]
    [InlineData("133", "QixFooFoo")]
    [InlineData("134", "Foo")]
    [InlineData("135", "FooBarFooBar")]
    [InlineData("136", "Foo")]
    [InlineData("137", "FooQix")]
    [InlineData("138", "FooFoo")]
    [InlineData("139", "Foo")]
    [InlineData("140", "BarQix")]
    [InlineData("141", "Foo")]
    [InlineData("142", "142")]
    [InlineData("143", "Foo")]
    [InlineData("144", "Foo")]
    [InlineData("145", "BarBar")]
    [InlineData("146", "146")]
    [InlineData("147", "FooQixQix")]
    [InlineData("148", "148")]
    [InlineData("149", "149")]
    [InlineData("150", "FooBarBar")]
    [InlineData("151", "Bar")]
    [InlineData("152", "Bar")]
    [InlineData("153", "FooBarFoo")]
    [InlineData("154", "QixBar")]
    [InlineData("155", "BarBarBar")]
    [InlineData("156", "FooBar")]
    [InlineData("157", "BarQix")]
    [InlineData("158", "Bar")]
    [InlineData("159", "FooBar")]
    [InlineData("160", "Bar")]
    [InlineData("161", "Qix")]
    [InlineData("162", "Foo")]
    [InlineData("163", "Foo")]
    [InlineData("164", "164")]
    [InlineData("165", "FooBarBar")]
    [InlineData("166", "166")]
    [InlineData("167", "Qix")]
    [InlineData("168", "FooQix")]
    [InlineData("169", "169")]
    [InlineData("170", "BarQix")]
    [InlineData("171", "FooQix")]
    [InlineData("172", "Qix")]
    [InlineData("173", "QixFoo")]
    [InlineData("174", "FooQix")]
    [InlineData("175", "BarQixQixBar")]
    [InlineData("176", "Qix")]
    [InlineData("177", "FooQixQix")]
    [InlineData("178", "Qix")]
    [InlineData("179", "Qix")]
    [InlineData("180", "FooBar")]
    [InlineData("181", "181")]
    [InlineData("182", "Qix")]
    [InlineData("183", "FooFoo")]
    [InlineData("184", "184")]
    [InlineData("185", "BarBar")]
    [InlineData("186", "Foo")]
    [InlineData("187", "Qix")]
    [InlineData("188", "188")]
    [InlineData("189", "FooQix")]
    [InlineData("190", "Bar")]
    [InlineData("191", "191")]
    [InlineData("192", "Foo")]
    [InlineData("193", "Foo")]
    [InlineData("194", "194")]
    [InlineData("195", "FooBarBar")]
    [InlineData("196", "Qix")]
    [InlineData("197", "Qix")]
    [InlineData("198", "Foo")]
    [InlineData("199", "199")]
    [InlineData("200", "Bar")]
    [InlineData("201", "Foo")]
    [InlineData("202", "202")]
    [InlineData("203", "QixFoo")]
    [InlineData("204", "Foo")]
    [InlineData("205", "BarBar")]
    [InlineData("206", "206")]
    [InlineData("207", "FooQix")]
    [InlineData("208", "208")]
    [InlineData("209", "209")]
    [InlineData("210", "FooBarQix")]
    [InlineData("211", "211")]
    [InlineData("212", "212")]
    [InlineData("213", "FooFoo")]
    [InlineData("214", "214")]
    [InlineData("215", "BarBar")]
    [InlineData("216", "Foo")]
    [InlineData("217", "QixQix")]
    [InlineData("218", "218")]
    [InlineData("219", "Foo")]
    [InlineData("220", "Bar")]
    [InlineData("221", "221")]
    [InlineData("222", "Foo")]
    [InlineData("223", "Foo")]
    [InlineData("224", "Qix")]
    [InlineData("225", "FooBarBar")]
    [InlineData("226", "226")]
    [InlineData("227", "Qix")]
    [InlineData("228", "Foo")]
    [InlineData("229", "229")]
    [InlineData("230", "BarFoo")]
    [InlineData("231", "FooQixFoo")]
    [InlineData("232", "Foo")]
    [InlineData("233", "FooFoo")]
    [InlineData("234", "FooFoo")]
    [InlineData("235", "BarFooBar")]
    [InlineData("236", "Foo")]
    [InlineData("237", "FooFooQix")]
    [InlineData("238", "QixFoo")]
    [InlineData("239", "Foo")]
    [InlineData("240", "FooBar")]
    [InlineData("241", "241")]
    [InlineData("242", "242")]
    [InlineData("243", "FooFoo")]
    [InlineData("244", "244")]
    [InlineData("245", "BarQixBar")]
    [InlineData("246", "Foo")]
    [InlineData("247", "Qix")]
    [InlineData("248", "248")]
    [InlineData("249", "Foo")]
    [InlineData("250", "BarBar")]
    [InlineData("251", "Bar")]
    [InlineData("252", "FooQixBar")]
    [InlineData("253", "BarFoo")]
    [InlineData("254", "Bar")]
    [InlineData("255", "FooBarBarBar")]
    [InlineData("256", "Bar")]
    [InlineData("257", "BarQix")]
    [InlineData("258", "FooBar")]
    [InlineData("259", "QixBar")]
    [InlineData("260", "Bar")]
    [InlineData("261", "Foo")]
    [InlineData("262", "262")]
    [InlineData("263", "Foo")]
    [InlineData("264", "Foo")]
    [InlineData("265", "BarBar")]
    [InlineData("266", "Qix")]
    [InlineData("267", "FooQix")]
    [InlineData("268", "268")]
    [InlineData("269", "269")]
    [InlineData("270", "FooBarQix")]
    [InlineData("271", "Qix")]
    [InlineData("272", "Qix")]
    [InlineData("273", "FooQixQixFoo")]
    [InlineData("274", "Qix")]
    [InlineData("275", "BarQixBar")]
    [InlineData("276", "FooQix")]
    [InlineData("277", "QixQix")]
    [InlineData("278", "Qix")]
    [InlineData("279", "FooQix")]
    [InlineData("280", "BarQix")]
    [InlineData("281", "281")]
    [InlineData("282", "Foo")]
    [InlineData("283", "Foo")]
    [InlineData("284", "284")]
    [InlineData("285", "FooBarBar")]
    [InlineData("286", "286")]
    [InlineData("287", "QixQix")]
    [InlineData("288", "Foo")]
    [InlineData("289", "289")]
    [InlineData("290", "Bar")]
    [InlineData("291", "Foo")]
    [InlineData("292", "292")]
    [InlineData("293", "Foo")]
    [InlineData("294", "FooQix")]
    [InlineData("295", "BarBar")]
    [InlineData("296", "296")]
    [InlineData("297", "FooQix")]
    [InlineData("298", "298")]
    [InlineData("299", "299")]
    [InlineData("300", "FooBarFoo")]
    [InlineData("301", "QixFoo")]
    [InlineData("302", "Foo")]
    [InlineData("303", "FooFooFoo")]
    [InlineData("304", "Foo")]
    [InlineData("305", "BarFooBar")]
    [InlineData("306", "FooFoo")]
    [InlineData("307", "FooQix")]
    [InlineData("308", "QixFoo")]
    [InlineData("309", "FooFoo")]
    [InlineData("310", "BarFoo")]
    [InlineData("311", "Foo")]
    [InlineData("312", "FooFoo")]
    [InlineData("313", "FooFoo")]
    [InlineData("314", "Foo")]
    [InlineData("315", "FooBarQixFooBar")]
    [InlineData("316", "Foo")]
    [InlineData("317", "FooQix")]
    [InlineData("318", "FooFoo")]
    [InlineData("319", "Foo")]
    [InlineData("320", "BarFoo")]
    [InlineData("321", "FooFoo")]
    [InlineData("322", "QixFoo")]
    [InlineData("323", "FooFoo")]
    [InlineData("324", "FooFoo")]
    [InlineData("325", "BarFooBar")]
    [InlineData("326", "Foo")]
    [InlineData("327", "FooFooQix")]
    [InlineData("328", "Foo")]
    [InlineData("329", "QixFoo")]
    [InlineData("330", "FooBarFooFoo")]
    [InlineData("331", "FooFoo")]
    [InlineData("332", "FooFoo")]
    [InlineData("333", "FooFooFooFoo")]
    [InlineData("334", "FooFoo")]
    [InlineData("335", "BarFooFooBar")]
    [InlineData("336", "FooQixFooFoo")]
    [InlineData("337", "FooFooQix")]
    [InlineData("338", "FooFoo")]
    [InlineData("339", "FooFooFoo")]
    [InlineData("340", "BarFoo")]
    [InlineData("341", "Foo")]
    [InlineData("342", "FooFoo")]
    [InlineData("343", "QixFooFoo")]
    [InlineData("344", "Foo")]
    [InlineData("345", "FooBarFooBar")]
    [InlineData("346", "Foo")]
    [InlineData("347", "FooQix")]
    [InlineData("348", "FooFoo")]
    [InlineData("349", "Foo")]
    [InlineData("350", "BarQixFooBar")]
    [InlineData("351", "FooFooBar")]
    [InlineData("352", "FooBar")]
    [InlineData("353", "FooBarFoo")]
    [InlineData("354", "FooFooBar")]
    [InlineData("355", "BarFooBarBar")]
    [InlineData("356", "FooBar")]
    [InlineData("357", "FooQixFooBarQix")]
    [InlineData("358", "FooBar")]
    [InlineData("359", "FooBar")]
    [InlineData("360", "FooBarFoo")]
    [InlineData("361", "Foo")]
    [InlineData("362", "Foo")]
    [InlineData("363", "FooFooFoo")]
    [InlineData("364", "QixFoo")]
    [InlineData("365", "BarFooBar")]
    [InlineData("366", "FooFoo")]
    [InlineData("367", "FooQix")]
    [InlineData("368", "Foo")]
    [InlineData("369", "FooFoo")]
    [InlineData("370", "BarFooQix")]
    [InlineData("371", "QixFooQix")]
    [InlineData("372", "FooFooQix")]
    [InlineData("373", "FooQixFoo")]
    [InlineData("374", "FooQix")]
    [InlineData("375", "FooBarFooQixBar")]
    [InlineData("376", "FooQix")]
    [InlineData("377", "FooQixQix")]
    [InlineData("378", "FooQixFooQix")]
    [InlineData("379", "FooQix")]
    [InlineData("380", "BarFoo")]
    [InlineData("381", "FooFoo")]
    [InlineData("382", "Foo")]
    [InlineData("383", "FooFoo")]
    [InlineData("384", "FooFoo")]
    [InlineData("385", "BarQixFooBar")]
    [InlineData("386", "Foo")]
    [InlineData("387", "FooFooQix")]
    [InlineData("388", "Foo")]
    [InlineData("389", "Foo")]
    [InlineData("390", "FooBarFoo")]
    [InlineData("391", "Foo")]
    [InlineData("392", "QixFoo")]
    [InlineData("393", "FooFooFoo")]
    [InlineData("394", "Foo")]
    [InlineData("395", "BarFooBar")]
    [InlineData("396", "FooFoo")]
    [InlineData("397", "FooQix")]
    [InlineData("398", "Foo")]
    [InlineData("399", "FooQixFoo")]
    [InlineData("400", "Bar")]
    [InlineData("401", "401")]
    [InlineData("402", "Foo")]
    [InlineData("403", "Foo")]
    [InlineData("404", "404")]
    [InlineData("405", "FooBarBar")]
    [InlineData("406", "Qix")]
    [InlineData("407", "Qix")]
    [InlineData("408", "Foo")]
    [InlineData("409", "409")]
    [InlineData("410", "Bar")]
    [InlineData("411", "Foo")]
    [InlineData("412", "412")]
    [InlineData("413", "QixFoo")]
    [InlineData("414", "Foo")]
    [InlineData("415", "BarBar")]
    [InlineData("416", "416")]
    [InlineData("417", "FooQix")]
    [InlineData("418", "418")]
    [InlineData("419", "419")]
    [InlineData("420", "FooBarQix")]
    [InlineData("421", "421")]
    [InlineData("422", "422")]
    [InlineData("423", "FooFoo")]
    [InlineData("424", "424")]
    [InlineData("425", "BarBar")]
    [InlineData("426", "Foo")]
    [InlineData("427", "QixQix")]
    [InlineData("428", "428")]
    [InlineData("429", "Foo")]
    [InlineData("430", "BarFoo")]
    [InlineData("431", "Foo")]
    [InlineData("432", "FooFoo")]
    [InlineData("433", "FooFoo")]
    [InlineData("434", "QixFoo")]
    [InlineData("435", "FooBarFooBar")]
    [InlineData("436", "Foo")]
    [InlineData("437", "FooQix")]
    [InlineData("438", "FooFoo")]
    [InlineData("439", "Foo")]
    [InlineData("440", "Bar")]
    [InlineData("441", "FooQix")]
    [InlineData("442", "442")]
    [InlineData("443", "Foo")]
    [InlineData("444", "Foo")]
    [InlineData("445", "BarBar")]
    [InlineData("446", "446")]
    [InlineData("447", "FooQix")]
    [InlineData("448", "Qix")]
    [InlineData("449", "449")]
    [InlineData("450", "FooBarBar")]
    [InlineData("451", "Bar")]
    [InlineData("452", "Bar")]
    [InlineData("453", "FooBarFoo")]
    [InlineData("454", "Bar")]
    [InlineData("455", "BarQixBarBar")]
    [InlineData("456", "FooBar")]
    [InlineData("457", "BarQix")]
    [InlineData("458", "Bar")]
    [InlineData("459", "FooBar")]
    [InlineData("460", "Bar")]
    [InlineData("461", "461")]
    [InlineData("462", "FooQix")]
    [InlineData("463", "Foo")]
    [InlineData("464", "464")]
    [InlineData("465", "FooBarBar")]
    [InlineData("466", "466")]
    [InlineData("467", "Qix")]
    [InlineData("468", "Foo")]
    [InlineData("469", "Qix")]
    [InlineData("470", "BarQix")]
    [InlineData("471", "FooQix")]
    [InlineData("472", "Qix")]
    [InlineData("473", "QixFoo")]
    [InlineData("474", "FooQix")]
    [InlineData("475", "BarQixBar")]
    [InlineData("476", "QixQix")]
    [InlineData("477", "FooQixQix")]
    [InlineData("478", "Qix")]
    [InlineData("479", "Qix")]
    [InlineData("480", "FooBar")]
    [InlineData("481", "481")]
    [InlineData("482", "482")]
    [InlineData("483", "FooQixFoo")]
    [InlineData("484", "484")]
    [InlineData("485", "BarBar")]
    [InlineData("486", "Foo")]
    [InlineData("487", "Qix")]
    [InlineData("488", "488")]
    [InlineData("489", "Foo")]
    [InlineData("490", "BarQix")]
    [InlineData("491", "491")]
    [InlineData("492", "Foo")]
    [InlineData("493", "Foo")]
    [InlineData("494", "494")]
    [InlineData("495", "FooBarBar")]
    [InlineData("496", "496")]
    [InlineData("497", "QixQix")]
    [InlineData("498", "Foo")]
    [InlineData("499", "499")]
    [InlineData("500", "BarBar")]
    [InlineData("501", "FooBar")]
    [InlineData("502", "Bar")]
    [InlineData("503", "BarFoo")]
    [InlineData("504", "FooQixBar")]
    [InlineData("505", "BarBarBar")]
    [InlineData("506", "Bar")]
    [InlineData("507", "FooBarQix")]
    [InlineData("508", "Bar")]
    [InlineData("509", "Bar")]
    [InlineData("510", "FooBarBar")]
    [InlineData("511", "QixBar")]
    [InlineData("512", "Bar")]
    [InlineData("513", "FooBarFoo")]
    [InlineData("514", "Bar")]
    [InlineData("515", "BarBarBar")]
    [InlineData("516", "FooBar")]
    [InlineData("517", "BarQix")]
    [InlineData("518", "QixBar")]
    [InlineData("519", "FooBar")]
    [InlineData("520", "BarBar")]
    [InlineData("521", "Bar")]
    [InlineData("522", "FooBar")]
    [InlineData("523", "BarFoo")]
    [InlineData("524", "Bar")]
    [InlineData("525", "FooBarQixBarBar")]
    [InlineData("526", "Bar")]
    [InlineData("527", "BarQix")]
    [InlineData("528", "FooBar")]
    [InlineData("529", "Bar")]
    [InlineData("530", "BarBarFoo")]
    [InlineData("531", "FooBarFoo")]
    [InlineData("532", "QixBarFoo")]
    [InlineData("533", "BarFooFoo")]
    [InlineData("534", "FooBarFoo")]
    [InlineData("535", "BarBarFooBar")]
    [InlineData("536", "BarFoo")]
    [InlineData("537", "FooBarFooQix")]
    [InlineData("538", "BarFoo")]
    [InlineData("539", "QixBarFoo")]
    [InlineData("540", "FooBarBar")]
    [InlineData("541", "Bar")]
    [InlineData("542", "Bar")]
    [InlineData("543", "FooBarFoo")]
    [InlineData("544", "Bar")]
    [InlineData("545", "BarBarBar")]
    [InlineData("546", "FooQixBar")]
    [InlineData("547", "BarQix")]
    [InlineData("548", "Bar")]
    [InlineData("549", "FooBar")]
    [InlineData("550", "BarBarBar")]
    [InlineData("551", "BarBar")]
    [InlineData("552", "FooBarBar")]
    [InlineData("553", "QixBarBarFoo")]
    [InlineData("554", "BarBar")]
    [InlineData("555", "FooBarBarBarBar")]
    [InlineData("556", "BarBar")]
    [InlineData("557", "BarBarQix")]
    [InlineData("558", "FooBarBar")]
    [InlineData("559", "BarBar")]
    [InlineData("560", "BarQixBar")]
    [InlineData("561", "FooBar")]
    [InlineData("562", "Bar")]
    [InlineData("563", "BarFoo")]
    [InlineData("564", "FooBar")]
    [InlineData("565", "BarBarBar")]
    [InlineData("566", "Bar")]
    [InlineData("567", "FooQixBarQix")]
    [InlineData("568", "Bar")]
    [InlineData("569", "Bar")]
    [InlineData("570", "FooBarBarQix")]
    [InlineData("571", "BarQix")]
    [InlineData("572", "BarQix")]
    [InlineData("573", "FooBarQixFoo")]
    [InlineData("574", "QixBarQix")]
    [InlineData("575", "BarBarQixBar")]
    [InlineData("576", "FooBarQix")]
    [InlineData("577", "BarQixQix")]
    [InlineData("578", "BarQix")]
    [InlineData("579", "FooBarQix")]
    [InlineData("580", "BarBar")]
    [InlineData("581", "QixBar")]
    [InlineData("582", "FooBar")]
    [InlineData("583", "BarFoo")]
    [InlineData("584", "Bar")]
    [InlineData("585", "FooBarBarBar")]
    [InlineData("586", "Bar")]
    [InlineData("587", "BarQix")]
    [InlineData("588", "FooQixBar")]
    [InlineData("589", "Bar")]
    [InlineData("590", "BarBar")]
    [InlineData("591", "FooBar")]
    [InlineData("592", "Bar")]
    [InlineData("593", "BarFoo")]
    [InlineData("594", "FooBar")]
    [InlineData("595", "BarQixBarBar")]
    [InlineData("596", "Bar")]
    [InlineData("597", "FooBarQix")]
    [InlineData("598", "Bar")]
    [InlineData("599", "Bar")]
    [InlineData("600", "FooBar")]
    [InlineData("601", "601")]
    [InlineData("602", "Qix")]
    [InlineData("603", "FooFoo")]
    [InlineData("604", "604")]
    [InlineData("605", "BarBar")]
    [InlineData("606", "Foo")]
    [InlineData("607", "Qix")]
    [InlineData("608", "608")]
    [InlineData("609", "FooQix")]
    [InlineData("610", "Bar")]
    [InlineData("611", "611")]
    [InlineData("612", "Foo")]
    [InlineData("613", "Foo")]
    [InlineData("614", "614")]
    [InlineData("615", "FooBarBar")]
    [InlineData("616", "Qix")]
    [InlineData("617", "Qix")]
    [InlineData("618", "Foo")]
    [InlineData("619", "619")]
    [InlineData("620", "Bar")]
    [InlineData("621", "Foo")]
    [InlineData("622", "622")]
    [InlineData("623", "QixFoo")]
    [InlineData("624", "Foo")]
    [InlineData("625", "BarBar")]
    [InlineData("626", "626")]
    [InlineData("627", "FooQix")]
    [InlineData("628", "628")]
    [InlineData("629", "629")]
    [InlineData("630", "FooBarQixFoo")]
    [InlineData("631", "Foo")]
    [InlineData("632", "Foo")]
    [InlineData("633", "FooFooFoo")]
    [InlineData("634", "Foo")]
    [InlineData("635", "BarFooBar")]
    [InlineData("636", "FooFoo")]
    [InlineData("637", "QixFooQix")]
    [InlineData("638", "Foo")]
    [InlineData("639", "FooFoo")]
    [InlineData("640", "Bar")]
    [InlineData("641", "641")]
    [InlineData("642", "Foo")]
    [InlineData("643", "Foo")]
    [InlineData("644", "Qix")]
    [InlineData("645", "FooBarBar")]
    [InlineData("646", "646")]
    [InlineData("647", "Qix")]
    [InlineData("648", "Foo")]
    [InlineData("649", "649")]
    [InlineData("650", "BarBar")]
    [InlineData("651", "FooQixBar")]
    [InlineData("652", "Bar")]
    [InlineData("653", "BarFoo")]
    [InlineData("654", "FooBar")]
    [InlineData("655", "BarBarBar")]
    [InlineData("656", "Bar")]
    [InlineData("657", "FooBarQix")]
    [InlineData("658", "QixBar")]
    [InlineData("659", "Bar")]
    [InlineData("660", "FooBar")]
    [InlineData("661", "661")]
    [InlineData("662", "662")]
    [InlineData("663", "FooFoo")]
    [InlineData("664", "664")]
    [InlineData("665", "BarQixBar")]
    [InlineData("666", "Foo")]
    [InlineData("667", "Qix")]
    [InlineData("668", "668")]
    [InlineData("669", "Foo")]
    [InlineData("670", "BarQix")]
    [InlineData("671", "Qix")]
    [InlineData("672", "FooQixQix")]
    [InlineData("673", "QixFoo")]
    [InlineData("674", "Qix")]
    [InlineData("675", "FooBarQixBar")]
    [InlineData("676", "Qix")]
    [InlineData("677", "QixQix")]
    [InlineData("678", "FooQix")]
    [InlineData("679", "QixQix")]
    [InlineData("680", "Bar")]
    [InlineData("681", "Foo")]
    [InlineData("682", "682")]
    [InlineData("683", "Foo")]
    [InlineData("684", "Foo")]
    [InlineData("685", "BarBar")]
    [InlineData("686", "Qix")]
    [InlineData("687", "FooQix")]
    [InlineData("688", "688")]
    [InlineData("689", "689")]
    [InlineData("690", "FooBar")]
    [InlineData("691", "691")]
    [InlineData("692", "692")]
    [InlineData("693", "FooQixFoo")]
    [InlineData("694", "694")]
    [InlineData("695", "BarBar")]
    [InlineData("696", "Foo")]
    [InlineData("697", "Qix")]
    [InlineData("698", "698")]
    [InlineData("699", "Foo")]
    [InlineData("700", "BarQixQix")]
    [InlineData("701", "Qix")]
    [InlineData("702", "FooQix")]
    [InlineData("703", "QixFoo")]
    [InlineData("704", "Qix")]
    [InlineData("705", "FooBarQixBar")]
    [InlineData("706", "Qix")]
    [InlineData("707", "QixQixQix")]
    [InlineData("708", "FooQix")]
    [InlineData("709", "Qix")]
    [InlineData("710", "BarQix")]
    [InlineData("711", "FooQix")]
    [InlineData("2147483647", "QixFooQix")]
    [InlineData("18446744073709551615", "FooBarQixQixFooQixBarBarBar")]
    public void _3_Sunshine(string input, string output)
    {
        var result = _nonSenseService.Compute(input);
        result.Should().NotBeNull();
        result.Should().NotBeEmpty();
        result.Should().Be(output);
    }

    [Theory]
    [InlineData("0", "0")]
    [InlineData("-1", "-1")]
    [InlineData("-2", "-2")]
    [InlineData("", "")]
    [InlineData("asdfasdf", "asdfasdf")]
    public void _3_Sadness(string input, string output)
    {
        var result = _nonSenseService.Compute(input);
        result.Should().NotBeNull();
        result.Should().NotBeEmpty();
        result.Should().Be($"Incorrect input: {output}");
    }
}

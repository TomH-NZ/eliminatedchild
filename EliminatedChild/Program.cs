// See https://aka.ms/new-console-template for more information

using EliminatedChild;

IChildList childList = new ChildList();
IApi childApi = new Api();

var childData = childApi.GetChildDataAsync();
var childGame = new Process();

childGame.RemoveChild(childData, childList);
public Transform _selected;
if(_selected!=null){
    var selectionRenderer = _selected.GetComponent<Renderer>(); 
    selectionRenderer.material.color = Color.blue;
    _selected = null;
}
var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
RaycastHit hit;
if (Physics.Raycast(ray, out hit)){
    var selection = hit.transform;
    if (selection.name=="Arch" || selection.name=="Stairs")
    {
        Debug.Log("here");
        var selectionRenderer = selection.GetComponent<Renderer>();
        selectionRenderer.material.color = Color.yellow;
        _selected = selection;
    }
}

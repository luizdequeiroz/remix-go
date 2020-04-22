import React from 'react';
import MSTest from './ms-test';
import Swal from 'sweetalert2';

function MSCard(sheet) {

    const roll = (qtde, sids) => {
        Swal.fire({
            width: 800,
            showConfirmButton: false,
            html: `<iframe id='roll-rpg' src='http://a.teall.info/dice/?notation=${qtde}d${sids}&roll' frameborder="0" style="overflow:hidden" height="800" width="100%"></iframe>`
        });
    };

    return <div className={`card text-white bg-${sheet.type} m-2 without-border`} key={sheet.id}>
        <div className="card-body">
            <h5 className="card-title">
                <button className={`btn btn-${sheet.type}`}><strong>{sheet.characterName}</strong></button>
                <button className={`btn btn-${sheet.type} btn-sm pull-right`}><small>{sheet.age} anos</small></button>
                <button className={`btn btn-${sheet.type} btn-sm pull-right`}><small>{sheet.archetype}</small></button>
            </h5>
            <hr />
            <div className="card-text">
                <MSTest
                    type={sheet.type}
                    icon="ra ra-axe"
                    label="FÍSICO"
                    onLabelClick={() => alert('label clicked')}
                    testDiceQuantity={sheet.physicalTestDiceQuantity}
                    testDiceFaceQuantity={sheet.physicalTestDiceFaceQuantity}
                    onTestClick={roll}
                />
                <MSTest
                    type={sheet.type}
                    icon="fa fa-brain"
                    label="MENTAL"
                    onLabelClick={() => alert('label clicked')}
                    testDiceQuantity={sheet.mentalTestDiceQuantity}
                    testDiceFaceQuantity={sheet.mentalTestDiceFaceQuantity}
                    onTestClick={roll}
                />
                <MSTest
                    type={sheet.type}
                    icon="ra ra-fairy-wand"
                    label={sheet.genericTestDiceLabel.toUpperCase()}
                    onLabelClick={() => alert('label clicked')}
                    testDiceQuantity={sheet.genericTestDiceQuantity}
                    testDiceFaceQuantity={sheet.genericTestDiceFaceQuantity}
                    onTestClick={roll}
                />
            </div>
            <hr />
        </div>
    </div>;
}

export default MSCard;
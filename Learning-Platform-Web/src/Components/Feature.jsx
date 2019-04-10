import React from 'react';
import FeatureBox from './FeatureBox';


function Feature({subjects, images}) {

    const subjectNames = subjects.map(data => { return data.Name})
    const imageNames = images.map(data => { return data.Name})
    
    console.log(imageNames)

    
    return (
        <div id='features'>
            <div className="a-container">
                
                
                {subjects.map(subject => {
                    return <FeatureBox image={(images.filter(image => image.Name==subject.Name))[0].ImageFile} title={subject.Name}/>
                })}
                
            </div>
            
        </div>
    )
}

export default Feature
